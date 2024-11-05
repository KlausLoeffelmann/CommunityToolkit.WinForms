using CommunityToolkit.WinForms.Controls;

namespace EntryFormatterDemo;

public partial class FrmMain : Form
{
    public FrmMain()
    {
        InitializeComponent();
    }

    private async void DecimalFormatter_ValueChanged(object sender, CommunityToolkit.WinForms.TypedInputExtenders.ValueChangedEventArgs<decimal?> e)
    {
        TextBox textBox = (TextBox)sender;

        await consoleControl1.WriteLineAsync($"TextBox:{textBox.Name} - Old Value:{e.OldValue} - New Value:{e.Value}");
    }
}

public class DerivedTextBox : TextBox
{
    protected override void OnEnabledChanged(EventArgs e)
    {
        base.OnEnabledChanged(e);
    }
}
