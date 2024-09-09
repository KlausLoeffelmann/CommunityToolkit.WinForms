using CommunityToolkit.WinForms.EntryFormatter;

namespace EntryFormatterDemo;

public partial class FrmMain : Form
{
    public FrmMain()
    {
        InitializeComponent();
    }

    private void DateEntryFormatterComponent1_ValueChanged(object sender, ValueChangedEventArgs<DateTime> e)
    {
        if (sender == textBox1)
        {

        }
    }
}
