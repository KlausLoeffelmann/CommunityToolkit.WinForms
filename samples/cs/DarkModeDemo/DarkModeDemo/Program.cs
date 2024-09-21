namespace DarkModeDemo;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        //// To customize application configuration such as set high DPI settings or default font,
        //// see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();

        // Existing APIs:
        //Application.SetCompatibleTextRenderingDefault(false);
        //Application.SetDefaultFont(new Font("Segoe UI", 9.75f));
        //Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
        //Application.SetHighDpiMode(HighDpiMode.SystemAware);

        // New for .NET 9:
        Application.SetColorMode(SystemColorMode.Dark);
        Application.SetDefaultVisualStylesMode(VisualStylesMode.Latest);

        Application.Run(new FormMain()
        // Application.Run(new FormRenderTest()
        // Application.Run(new FormArrangeElementTest()
        {
            StartPosition = FormStartPosition.CenterScreen
        });
    }
}
