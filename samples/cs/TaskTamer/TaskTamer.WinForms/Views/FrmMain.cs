using CommunityToolkit.WinForms.Extensions;
using TaskTamer9.WinForms.ValueConverter;
using TaskTamer9.WinForms.Views;

namespace TaskTamer.WinForms;

public partial class FrmMain : Form
{
    public FrmMain()
    {
        InitializeComponent();

        _lblPercentDoneValue.AddBindingConverter(nameof(_lblPercentDoneValue.Text), ValueConverters.TaskPercentDoneToString);
        _lblPriority.AddBindingConverter(nameof(_lblPriority.Text), ValueConverters.PriorityToString);
        _tslSelectedTasksProjectInfo.AddBindingConverter(nameof(_tslSelectedTasksProjectInfo.Text), ValueConverters.ProjectVMToString);
        _tslLastEdited.AddBindingConverter(nameof(_tslLastEdited.Text), ValueConverters.DateModifiedToString);
    }

    // This is where we are setting up the Binding for this view.
    // We just assign the DataContext to the DataSource of the BindingSource.
    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);

        _mainVmSource.DataSource = DataContext;
    }

    private void TsmAsyncFormExperiments_Click(object sender, EventArgs e)
    {
        using FrmAsyncExperiments frm = new();
        frm.ShowDialog();
    }
}
