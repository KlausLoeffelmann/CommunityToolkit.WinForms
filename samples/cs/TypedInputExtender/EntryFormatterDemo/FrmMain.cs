using CommunityToolkit.WinForms.Controls;
using CommunityToolkit.WinForms.TypedInputExtenders;

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
        consoleControl1.SetStyle(
            style: CustomFontStyle.Bold, 
            keepSetting: true);

        await consoleControl1.WriteLineAsync($"TextBox:{textBox.Name} - Old Value:{e.OldValue} - New Value:{e.Value}");
    }
}
