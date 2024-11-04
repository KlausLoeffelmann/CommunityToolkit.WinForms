namespace CommunityToolkit.WinForms.Extensions.FormAndControlExtensions.AsyncProperties;

using System.ComponentModel;
using System.Windows.Forms;

public class AsyncTypeDescriptor : CustomTypeDescriptor
{
    private readonly Control _control;

    public AsyncTypeDescriptor(ICustomTypeDescriptor? parent, Control control)
        : base(parent)
    {
        _control = control;
    }

    public override PropertyDescriptorCollection GetProperties()
    {
        PropertyDescriptorCollection originalProps = base.GetProperties();
        PropertyDescriptor[] newProps = new PropertyDescriptor[originalProps.Count];

        for (int i = 0; i < originalProps.Count; i++)
        {
            PropertyDescriptor prop = originalProps[i];
            newProps[i] = new AsyncControlPropertyDescriptor(prop, _control);
        }

        return new PropertyDescriptorCollection(newProps);
    }
}
