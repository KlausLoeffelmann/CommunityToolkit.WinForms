﻿using CommunityToolkit.WinForms.AI.TypedInput;
using CommunityToolkit.WinForms.TypedInputExtenders;

namespace WinFormsSkPlayGround.Components;

[ToolboxBitmap(typeof(AITextFormatterComponent), "AIFormattedTextEntry.bmp")]
public partial class AITripFormatterComponent
    : TypedFormatterComponent<string?>
{
    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
        => base.Dispose(disposing);

    public override string? GetValue(Control textBox)
        => base.GetValueInternal((TextBox)textBox);

    public override void SetValue(Control textBox, string? value)
        => base.SetValueInternal((TextBox)textBox, value);

    protected override ITypedFormatter<string?> GetDefaultFormatterInstance()
        => (ITypedFormatter<string?>)new AITripFormatter();

    protected override object GetDefaultValue()
        => string.Empty;

    protected override bool CanExtendProperties(object formatterComponent)
        => formatterComponent is AITripFormatterComponent;
}
