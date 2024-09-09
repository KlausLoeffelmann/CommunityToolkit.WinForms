using System.Windows.Forms.Layout;

namespace DarkModeDemo.ArrangeElement;

public class TextBoxEx : TextBox
{
    private readonly TextBoxExLayoutEngine _layoutEngine;

    private class TextBoxExLayoutEngine : LayoutEngine
    {
        public override void InitLayout(object child, BoundsSpecified specified)
        {
            LayoutEngineBase.InitLayout(child, specified);
        }

        public override bool Layout(object container, LayoutEventArgs layoutEventArgs)
        {
            return LayoutEngineBase.Layout(container, layoutEventArgs);
        }

        public LayoutEngine LayoutEngineBase { get; set; } = null!;
    }

    public TextBoxEx()
    {
        _layoutEngine = new TextBoxExLayoutEngine();
    }

    public override LayoutEngine LayoutEngine
    {
        get
        {
            _layoutEngine.LayoutEngineBase ??= base.LayoutEngine;
            return _layoutEngine;
        }
    }

    protected override void OnLayout(LayoutEventArgs levent)
    {
        base.OnLayout(levent);
    }
}
