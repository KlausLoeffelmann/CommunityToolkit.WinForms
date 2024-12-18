using TaskTamer.ViewModels;
using TaskTamer.WinForms.Views;
using static CommunityToolkit.WinForms.Mvvm.IWinFormsStartService;

namespace TaskTamer.WinForms;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();

        Application.SetColorMode(SystemColorMode.System);

        // We're registering the ViewModels and the view here:
        RegisterView<ProjectViewModel>(() => new FrmManageProjects());
        RegisterView<MainViewModel>(() => new FrmMain());

        // We're setting the start ViewModel here:
        SetStartViewModel<MainViewModel>();

        // Let's go!
        Run();
    }
}
