
using CommunityToolkit.WinForms.FluentUI.Imaging;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace PictureViewer;

public partial class FrmMain : Form
{
    private ObservableCollection<AsyncPictureComponent>? _imageFiles;

    public FrmMain()
    {
        InitializeComponent();
        _imageGridView.GridViewItemTemplate = new ImageItem();
        _txtLabel.Text = "C:\\PicTemp";
    }

    protected async override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);

        await Task.Run(() => GetImageFileList());
        _tslStatus.Text = $"{_imageFiles?.Count()} images found.";
        _imageGridView.DataContext = _imageFiles;
    }

    private void GetImageFileList()
    {
        _imageFiles = [.. ImageFileInfo.GetImageFiles(_txtLabel.Text)
                            .Select(imageInfoItem => new AsyncPictureComponent(imageInfoItem))];

        foreach (var imageFile in _imageFiles)
        {
            Debug.Print(imageFile.ImageFileInfo?.FullName);
        }
    }
}
