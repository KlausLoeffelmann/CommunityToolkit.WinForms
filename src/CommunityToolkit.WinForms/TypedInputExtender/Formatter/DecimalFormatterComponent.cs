
namespace CommunityToolkit.WinForms.TypedInputExtenders;

public partial class DecimalFormatterComponent : DataEntryFormatterComponent<Decimal?>
{
    public override decimal? GetValue(Control dataEntry)
    {
        return base.GetValueInternal((TextBox) dataEntry);
    }

    public override void SetValue(Control dataEntry, decimal? value)
    {
        base.SetValueInternal((TextBox) dataEntry, value);
    }

    protected override ITypedFormatter<decimal?> GetDefaultFormatterInstance()
    {
        return (ITypedFormatter<decimal?>) new DecimalFormatter();
    }

    protected override bool CanExtendProperties(object formatterComponent)
        => formatterComponent is DecimalFormatterComponent;
}
