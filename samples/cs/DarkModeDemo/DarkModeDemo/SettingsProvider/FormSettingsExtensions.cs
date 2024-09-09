namespace DarkModeDemo.SettingsProvider;

public static class FormSettingsExtensions
{
    public static void LoadBounds(this Form form)
    {
        DynamicSettings.Instance.LoadSettings();

        if (DynamicSettings.GetValue<Point>($"FormLocation.{form.Name}") is Point location
            && DynamicSettings.GetValue<Size>($"FormSize.{form.Name}") is Size size)
        {
            form.Location = location;
            form.Size = size;
        }
    }

    public static void SaveBounds(this Form form)
    {
        if (form.WindowState == FormWindowState.Normal)
        {
            DynamicSettings.SetValue($"FormLocation.{form.Name}", form.Location);
            DynamicSettings.SetValue($"FormSize.{form.Name}", form.Size);
        }
        else
        {
            DynamicSettings.SetValue($"FormLocation.{form.Name}", form.RestoreBounds.Location);
            DynamicSettings.SetValue($"FormSize.{form.Name}", form.RestoreBounds.Size);
        }
    }
}
