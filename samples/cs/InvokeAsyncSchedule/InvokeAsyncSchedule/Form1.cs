namespace InvokeAsyncSchedule;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private async void TextBox_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Down)
        {
            _textBox.Text = "Some text to pick from";
            _textBox.SelectAll();
            // e.Handled = true;

            await InvokeAsync(() => _textBox.SelectAll());
        }
    }
}
