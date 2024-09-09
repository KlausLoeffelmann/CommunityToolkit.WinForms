using System.ComponentModel;

namespace SemanticKernelDemo;

[ToolboxItem(false)]
public partial class PromptControlV1 : TextBox
{
    private readonly static Padding s_defaultPadding = new(5, 5, 30, 5);

    public PromptControlV1()
    {
        VisualStylesMode = VisualStylesMode.Latest;
        Multiline = true;
        Padding = s_defaultPadding;
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public new Padding Padding
    {
        get => base.Padding;
        set => base.Padding = value;
    }
}
