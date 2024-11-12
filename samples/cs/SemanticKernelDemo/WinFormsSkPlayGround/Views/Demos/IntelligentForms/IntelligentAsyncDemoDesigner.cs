using CommunityToolkit.WinForms.Extensions;

namespace WinFormsSkPlayGround.Views;

public partial class IntelligentAsyncDemoDesigner : UserControl
{
    private Form _parentForm;
    private StatusStrip _parentStatusStrip;

    public IntelligentAsyncDemoDesigner(Form parentForm)
    {
        InitializeComponent();
        _parentForm = parentForm;
        _parentStatusStrip = parentForm.FirstDescendant<StatusStrip>();
    }
}
