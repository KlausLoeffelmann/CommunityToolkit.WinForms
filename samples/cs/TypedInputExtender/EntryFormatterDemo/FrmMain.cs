using CommunityToolkit.WinForms.TypedInputExtenders;

namespace EntryFormatterDemo;

public partial class FrmMain : Form
{
    public FrmMain()
    {
        InitializeComponent();
    }

    private void DecimalFormatter_ValueChanged(object sender, CommunityToolkit.WinForms.TypedInputExtenders.ValueChangedEventArgs<decimal?> e)
    {
        TextBox textBox = (TextBox)sender;
        label1.Text = $"TextBox:{textBox.Name} - Old Value:{e.Value} - New Value:{e.OldValue}";
    }
}
