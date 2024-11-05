using System.Diagnostics;

namespace EntryFormatterDemo;

public class DerivedTextBox : TextBox
{
    protected override void OnEnabledChanged(EventArgs e)
    {
        base.OnEnabledChanged(e);
    }

    protected override void OnTextChanged(EventArgs e)
    {
        base.OnTextChanged(e);
        if (this.Text.Length == 5 && Debugger.IsAttached)
        {
            //Debugger.Break();
        }
    }
}
