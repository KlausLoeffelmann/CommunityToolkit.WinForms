using CommunityToolkit.WinForms.AsyncSupport;
using CommunityToolkit.WinForms.FluentUI.Imaging;
using System.Collections.ObjectModel;

namespace PictureViewer;

public partial class FrmMain : Form
{
    private ObservableCollection<AsyncPictureComponent>? _imageFiles;
    private readonly AwaitableEvent<EventArgs> _awaitableMenuClose = new();
    private readonly AwaitableEvent<DataGridViewCellEventArgs> _awaitablePictureDoubleClick = new();

    public FrmMain()
    {
        InitializeComponent();

        _imageGridView.GridViewItemTemplate = new ImageItem(_imageGridView);
        _tslBasePath.Text = "C:\\DemoPics";

        _imageGridView.CellContentDoubleClick += (s, e) => _awaitablePictureDoubleClick.EventAction.Invoke(s!,e);
        _imageGridView.CellDoubleClick += (s, e) => _awaitablePictureDoubleClick.EventAction.Invoke(s!, e);

        _tsmQuit.Click += (s, e) => _awaitableMenuClose.EventAction.Invoke(s!,e);

        this.ClientSize = new(1600, 900);
    }

    protected async override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);

        await Task.Run(() => GetImageFileList());

        _tslStatus.Text = $"{_imageFiles?.Count} images found.";
        _imageGridView.DataContext = _imageFiles;

        // This is a lookup-table for the DocumentForms and their corresponding Tasks.
        List<IAwaitableComponent> awaitableComponents = [];

        // This is the respective next DocumentForm to be created.
        FrmDocument documentForm;

        // We're in a loop until the Quit-MenuItem is clicked.
        while (true)
        {
            // Wait for any of the passed Tasks to complete.
            // We pass the Tasks of all DocumentForms, the Task of the New Document MenuItem
            // and the Task of the Quit MenuItem. The first one to complete is awaited, and it is
            // returned once it completes.
            var awaitedTask = await awaitableComponents.WhenAny(
                _awaitableMenuClose, 
                _awaitablePictureDoubleClick);

            if (awaitedTask == null)
            {
                break;
            }
            else if (awaitedTask == _awaitablePictureDoubleClick)
            {
                var asyncImage = _imageFiles?[_awaitablePictureDoubleClick.EArgs.RowIndex];
                documentForm = new FrmDocument(asyncImage!);
                awaitableComponents.Add(new AwaitableForm(documentForm));
            }
            else if (awaitedTask == _awaitableMenuClose)
            {
                break;
            }
            else
            {
                documentForm = (FrmDocument)((AwaitableForm)awaitedTask).Form; 
                awaitableComponents.Remove(awaitedTask);
            }
        }

        // Close the main form, and with it, all still open DocumentForms.
        Close();
    }

    private void GetImageFileList()
    {
        _imageFiles = [.. ImageFileInfo.GetImageFiles(_tslBasePath.Text ?? "C:\\")
            .Select(imageInfoItem => new AsyncPictureComponent(imageInfoItem))];

        foreach (var imageFile in _imageFiles)
        {
            InvokeAsync(() => _tslCurrentImageItem.Text = imageFile?.ImageFileInfo?.FullName);
        }
    }
}
