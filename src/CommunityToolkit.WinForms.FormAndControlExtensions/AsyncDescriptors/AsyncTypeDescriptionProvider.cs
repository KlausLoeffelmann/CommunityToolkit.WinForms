namespace CommunityToolkit.WinForms.Extensions.FormAndControlExtensions.AsyncProperties;

using System;
using System.ComponentModel;
using System.Windows.Forms;

public class AsyncTypeDescriptionProvider(Control component) : TypeDescriptionProvider
{
    public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object? instance) 
        => new AsyncTypeDescriptor(TypeDescriptor.GetProvider(objectType).GetTypeDescriptor(objectType, instance), component);
}
