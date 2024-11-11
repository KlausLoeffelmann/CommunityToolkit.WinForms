namespace WinFormsSkPlayGround.Views;

[ToolboxBitmap(typeof(IntelligentAsyncEntryFormsView), "MvvmView.bmp")]
public partial class IntelligentAsyncEntryFormsView : UserControl
{
    public IntelligentAsyncEntryFormsView()
    {
        InitializeComponent();

        if (Application.IsDarkModeEnabled)
        {
            // We need to manual color the background for dark mode for read-only textboxes.
            _txtAutomaticTripInfo.BackColor = Color.FromArgb(255, 10, 10, 10);
        }
    }
}
