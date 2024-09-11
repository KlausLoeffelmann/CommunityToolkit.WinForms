using static CommunityToolkit.WinForms.TypedInputExtenders.DateFormatterComponent;

namespace CommunityToolkit.WinForms.TypedInputExtenders;

public partial class IntelDateFormatterComponent
    : DataEntryFormatterComponent<DateTime>
{
    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
        => base.Dispose(disposing);

    public override DateTime GetValue(Control textBox)
        => base.GetValueInternal((TextBox)textBox);

    public override void SetValue(Control textBox, DateTime value)
        => base.SetValueInternal((TextBox)textBox, value);

    protected override ITypedFormatter<DateTime> GetDefaultFormatterInstance()
        => (ITypedFormatter<DateTime>)new DateFormatter();

    protected override object GetDefaultValue()
        => DateTime.Now.Date;

    protected override bool CanExtendProperties(object formatterComponent)
        => formatterComponent is DateFormatterComponent;
}
