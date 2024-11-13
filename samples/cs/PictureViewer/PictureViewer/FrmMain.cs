
using CommunityToolkit.WinForms.FluentUI.Imaging;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace PictureViewer;

public partial class FrmMain : Form
{
    private ObservableCollection<AsyncPictureComponent>? _imageFiles;

    AwaitableEvent<EventArgs> _awaitableMenuClose=new();
    AwaitableEvent<DataGridViewCellEventArgs> _awaitablePictureDoubleClick = new();

    public FrmMain()
    {
        InitializeComponent();

        _imageGridView.GridViewItemTemplate = new ImageItem(_imageGridView);
        _tslBasePath.Text = "C:\\PicTemp";

        _imageGridView.CellContentDoubleClick += (s, e) => _awaitablePictureDoubleClick.EventAction.Invoke(s!,e);
        _imageGridView.CellDoubleClick += (s, e) => _awaitablePictureDoubleClick.EventAction.Invoke(s!, e);

        _tsmQuit.Click += (s, e) => _awaitableMenuClose.EventAction.Invoke(s!,e);
    }

    protected async override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);

        await Task.Run(() => GetImageFileList());
        _tslStatus.Text = $"{_imageFiles?.Count()} images found.";
        _imageGridView.DataContext = _imageFiles;

        // This is a lookup-table for the DocumentForms and their corresponding Tasks.
        var formTasks = new Dictionary<Task, FrmDocument>();

        // This is the respective next DocumentForm to be created.
        FrmDocument documentForm;


        // We're in a loop until the Quit-MenuItem is clicked.
        while (true)
        {
            // Wait for any of the passed Tasks to complete.
            // We pass the Tasks of all DocumentForms, the Task of the New Document MenuItem
            // and the Task of the Quit MenuItem. The first one to complete is awaited, and it is
            // returned once it completes.
            var awaitedTask = await Task.WhenAny(
                Combine(
                    formTasks.Keys,
                    _awaitablePictureDoubleClick.ToTask(),
                    _awaitableMenuClose.ToTask()));

            // If that task was the Task of the New Document MenuItem, we create a new DocumentForm.
            if (awaitedTask == _awaitablePictureDoubleClick.ToTask())
            {
                var result = _awaitablePictureDoubleClick.ToTask().Result.Item2;
                var eArgs=result as DataGridViewCellEventArgs;
                var asyncImage= _imageFiles?[eArgs!.RowIndex];
                documentForm = new FrmDocument(asyncImage!);

                formTasks.Add(documentForm.ShowAsync(), documentForm);
            }
            // If that task was the Task of the Quit MenuItem, we exit the loop.
            else if (awaitedTask == _awaitableMenuClose.ToTask())
            {
                break;
            }

            // And if it was the Task of a DocumentForm, we remove that DocumentForm from the lookup-table
            // because this task completes when the Form is closing.
            else
            {
                documentForm = formTasks[awaitedTask];
                formTasks.Remove(awaitedTask);
            }
        }

        // Close the main form, and with it, all still open DocumentForms.
        Close();
    }

    // Helper function to combine multiple Tasks into one IEnumerable<Task>, so we can pass them to Task.WhenAny.
    private static IEnumerable<Task> Combine(IEnumerable<Task> list, params Task[] additionalItems)
    {
        return list.Concat(additionalItems);
    }

    private void GetImageFileList()
    {
        _imageFiles = [.. ImageFileInfo.GetImageFiles(_tslBasePath.Text ?? "C:\\")
                            .Select(imageInfoItem => new AsyncPictureComponent(imageInfoItem))];

        foreach (var imageFile in _imageFiles)
        {
            Debug.Print(imageFile.ImageFileInfo?.FullName);
        }
    }
}

public class AwaitableEvent<T>
{
    // TaskCompletionSource, providing a task that completes when the ToolStripMenuItem is clicked.
    private TaskCompletionSource<(object?, EventArgs)> _clickCompletion = new();
    private readonly Action<object?, EventArgs> _eventAction;

    public AwaitableEvent()
    {
        _eventAction = (s, e) =>
        {
            // Complete the task and immediately prepare for the next click event.
            _clickCompletion.TrySetResult((s, e));
            _clickCompletion = new TaskCompletionSource<(object?, EventArgs)>();
        };
    }

    public Action<object, EventArgs> EventAction => _eventAction;

    /// <summary>
    /// Returns a Task that completes when the ToolStripMenuItem is clicked.
    /// </summary>
    public Task<(object?, EventArgs)> ToTask() => _clickCompletion.Task;
}
