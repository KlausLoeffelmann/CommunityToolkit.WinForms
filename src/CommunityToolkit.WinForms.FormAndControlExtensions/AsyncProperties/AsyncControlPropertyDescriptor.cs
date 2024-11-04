namespace CommunityToolkit.WinForms.Extensions.FormAndControlExtensions.AsyncProperties;

using System;
using System.ComponentModel;
using System.Windows.Forms;

public class AsyncControlPropertyDescriptor : PropertyDescriptor
{
    private readonly PropertyDescriptor _originalDescriptor;
    private readonly Control _control;

    public AsyncControlPropertyDescriptor(PropertyDescriptor original, Control control)
        : base(original)
    {
        _originalDescriptor = original;
        _control = control;
    }

    public override object? GetValue(object? component)
    {
        if (_control.InvokeRequired)
        {
            return _control.Invoke(() => _originalDescriptor.GetValue(component));
        }
        return _originalDescriptor.GetValue(component);
    }

    public override void SetValue(object? component, object? value)
    {
        if (_control.InvokeRequired)
        {
            _control.Invoke(() => _originalDescriptor.SetValue(component, value));
        }
        else
        {
            _originalDescriptor.SetValue(component, value);
        }
    }

    // Required overrides that delegate to the original descriptor
    public override Type ComponentType => _originalDescriptor.ComponentType;
    public override bool IsReadOnly => _originalDescriptor.IsReadOnly;
    public override Type PropertyType => _originalDescriptor.PropertyType;
    public override bool CanResetValue(object component) => _originalDescriptor.CanResetValue(component);
    public override void ResetValue(object component) => _originalDescriptor.ResetValue(component);
    public override bool ShouldSerializeValue(object component) => _originalDescriptor.ShouldSerializeValue(component);
}
