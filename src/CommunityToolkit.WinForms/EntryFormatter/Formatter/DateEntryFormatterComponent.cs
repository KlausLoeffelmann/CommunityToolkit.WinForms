namespace CommunityToolkit.WinForms.EntryFormatter;

public partial class DateEntryFormatterComponent : DataEntryFormatterComponent<DateTime>
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

    protected override IDataEntryFormatter<DateTime> GetDefaultFormatterInstance() 
        => (IDataEntryFormatter<DateTime>)new DateDataEntryFormatter();

    protected override object GetDefaultValue() 
        => DateTime.Now.Date;

    protected override bool CanExtendProperties(object formatterComponent) 
        => formatterComponent is DateEntryFormatterComponent;
}
