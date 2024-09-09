namespace CommunityToolkit.WinForms.EntryFormatter;

public partial class DecimalEntryFormatterComponent : DataEntryFormatterComponent<Decimal?>
{
    public override decimal? GetValue(Control dataEntry)
    {
        return base.GetValueInternal((TextBox) dataEntry);
    }

    public override void SetValue(Control dataEntry, decimal? value)
    {
        base.SetValueInternal((TextBox) dataEntry, value);
    }

    protected override IDataEntryFormatter<decimal?> GetDefaultFormatterInstance()
    {
        return (IDataEntryFormatter<decimal?>) new DecimalDataEntryFormatter();
    }

    protected override bool CanExtendProperties(object formatterComponent)
        => formatterComponent is DecimalEntryFormatterComponent;
}
