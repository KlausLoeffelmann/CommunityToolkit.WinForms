using System.ComponentModel;

namespace CommunityToolkit.WinForms.FluentUI.Imaging;

public class AsyncPictureComponent : BindableComponent
{
    public event EventHandler? ImageFileInfoChanged;
    public event EventHandler? BitmapChanged;
    public event EventHandler? AutoDisposeOnObscuredTimeChanged;
    public event EventHandler? AutoLoadChanged;
    public event EventHandler? ExifDataLoaded;

    private ImageFileInfo? _imageFileInfo;
    private Bitmap? _bitmap;
    private TimeSpan? _autoDisposeOnObscuredTime;
    private bool _autoLoad = false;

    public AsyncPictureComponent()
    {
    }

    public AsyncPictureComponent(ImageFileInfo imageFileInfo)
    {
        ImageFileInfo = imageFileInfo;
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public ImageFileInfo? ImageFileInfo
    {
        get => _imageFileInfo;
        set
        {
            if (_imageFileInfo == value)
            {
                return;
            }

            _imageFileInfo = value;
            OnImageFileInfoChanged();
        }
    }

    protected virtual async void OnImageFileInfoChanged()
    {
        ImageFileInfoChanged?.Invoke(this, EventArgs.Empty);

        Task bitmapLoaderTask = Task.CompletedTask;
        Task exifLoaderTask = Task.CompletedTask;

        if (AutoLoad && ImageFileInfo != null)
        {
            bitmapLoaderTask = ImageFileInfo
                .LoadImageAsync()
                .ContinueWith((bitmap) => 
                {
                    _bitmap = bitmap.Result;
                    OnBitmapChanged();
                });
        }

        if (ImageFileInfo != null)
        {
            exifLoaderTask = ImageFileInfo
                .GetExifInfoAsync(this)
                .ContinueWith((obj) =>
                {
                    OnExifDataLoaded();
                });
        }

        await Task.WhenAll(bitmapLoaderTask, exifLoaderTask);
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public Bitmap? Bitmap => _bitmap;

    protected virtual void OnBitmapChanged() 
        => BitmapChanged?.Invoke(this, EventArgs.Empty);

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    [DefaultValue(null)]
    public TimeSpan? AutoDisposeOnObscuredTime
    {
        get => _autoDisposeOnObscuredTime;
        set
        {
            if (_autoDisposeOnObscuredTime == value)
            {
                return;
            }
            _autoDisposeOnObscuredTime = value;
            OnAutoDisposeOnObscuredTimeChanged();
        }
    }

    protected virtual void OnAutoDisposeOnObscuredTimeChanged()
        => AutoDisposeOnObscuredTimeChanged?.Invoke(this, EventArgs.Empty);

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    [DefaultValue(false)]
    public bool AutoLoad
    {
        get => _autoLoad;
        set
        {
            if (_autoLoad == value)
            {
                return;
            }
            _autoLoad = value;
            OnAutoLoadChanged();
        }
    }

    protected virtual void OnAutoLoadChanged()
        => AutoLoadChanged?.Invoke(this, EventArgs.Empty);

    protected virtual void OnExifDataLoaded()
        => ExifDataLoaded?.Invoke(this, EventArgs.Empty);
}
