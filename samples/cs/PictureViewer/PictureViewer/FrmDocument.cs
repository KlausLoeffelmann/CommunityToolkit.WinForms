using CommunityToolkit.WinForms.FluentUI.Imaging;

namespace PictureViewer;

public partial class FrmDocument : Form
{
    public FrmDocument()
    {
        InitializeComponent();
    }

    public FrmDocument(AsyncPictureComponent picture)
    {
        InitializeComponent();
        _pictureBox.Image = picture.Bitmap;
    }
}
