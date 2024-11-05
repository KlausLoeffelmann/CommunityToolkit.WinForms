

namespace CommunityToolkit.WinForms.TypedInputExtenders;

public abstract partial class TypedFormatterComponent<T>
{
    public class ValueConvertEventArgs : EventArgs
    {
        internal ValueConvertEventArgs(TextBox textBox)
        {
            TextBox = textBox;
            IndicateBusy = true;
            PreventChangesWhileBusy = true;
        }

        public TextBox TextBox { get; }
        public bool IndicateBusy { get; set; }
        public bool PreventChangesWhileBusy { get; set; }

        internal CancellationTokenSource? CancellationTokenSource { get; set; }
        internal SpinnerControl? Spinner { get; set; }
        internal Task? SpinnerTask { get; set; }
    }
}
