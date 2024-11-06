using System.Diagnostics;

namespace TaskTamer9.WinForms.Views;

public partial class FrmAsyncExperiments : Form
{
    public FrmAsyncExperiments()
    {
        InitializeComponent();
    }

    private async void BtnTestSemanticKernel_Click(object sender, EventArgs e)
    {
        var test = new TypedInputKernelPlugin();
        string? result = await test.RunAsync();
        Debug.Print(result);
    }
}
