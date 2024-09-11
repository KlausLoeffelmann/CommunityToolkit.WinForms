using Microsoft.Extensions.Hosting;

namespace SemanticKernelDemo;

internal static class Program
{
    public static WinFormsHost WinFormsHost { get; private set; } = null!;

    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        Application.SetColorMode(SystemColorMode.Dark);

        #region "Copilot Demo"

        #region Prompt
        // I read the comment for WinFormsHost, but I do not understand it. Where is the
        // the typical Application.Run() call that starts the WinForms application, and
        // what's with the IHost and Blazor stuff? Can you explain it to me?
        #endregion

        // WinFormsHost is using IHost of Microsoft.Extensions.Hosting and
        // provide DI, so we can easily communicate between different parts of the application.
        // for example between a Blazor component and a WinForms form.
        WinFormsHost = WinFormsHost.Initialize(
            startFormType: typeof(FrmMain),
            colorMode: SystemColorMode.Classic,
            visualStylesMode: VisualStylesMode.Latest);
        WinFormsHost.Start();

#endregion
    }
}
