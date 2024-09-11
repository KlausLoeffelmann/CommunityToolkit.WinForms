using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace SemanticKernelDemo;

#region Prompt:
// Can you refactor this class by translating the German phrases in to English?
#endregion

/// <summary>
/// Stellt einen Host für eine WinForms-Anwendung dar.
/// </summary>
public class WinFormsHost : IHost
{
    private bool disposedValue;
    private readonly IHost _innerHost;
    private readonly SystemColorMode _colorMode;
    private readonly VisualStylesMode _visualStylesMode;

    private static IHost? s_host;

    /// <summary>
    /// Initialisiert eine neue Instanz der <see cref="WinFormsHost"/>-Klasse.
    /// </summary>
    /// <param name="host">Der innere Host.</param>
    /// <param name="colorMode">Der Systemfarbmodus.</param>
    /// <param name="visualStylesMode">Der visuelle Stilmodus.</param>
    private WinFormsHost(
        IHost host,
        SystemColorMode colorMode,
        VisualStylesMode visualStylesMode)
    {
        _innerHost = host;
        _colorMode = colorMode;
        _visualStylesMode = visualStylesMode;
    }

    /// <summary>
    /// Ruft die vom Host bereitgestellten Dienste ab.
    /// </summary>
    public IServiceProvider Services => _innerHost.Services;

    /// <summary>
    /// Initialisiert den WinForms-Host.
    /// </summary>
    /// <param name="startFormType">Der Typ des Startformulars.</param>
    /// <param name="colorMode">Der Systemfarbmodus. Standardmäßig ist <see cref="SystemColorMode.Classic"/>.</param>
    /// <param name="visualStylesMode">Der visuelle Stilmodus. Standardmäßig ist <see cref="VisualStylesMode.Classic"/>.</param>
    /// <returns>Der initialisierte <see cref="WinFormsHost"/>.</returns>
    public static WinFormsHost Initialize(
        Type startFormType,
        SystemColorMode colorMode = SystemColorMode.Classic,
        VisualStylesMode visualStylesMode = VisualStylesMode.Classic)
    {
        if (s_host is not null)
        {
            s_host.Services.GetRequiredService<ILogger<WinFormsHost>>().LogWarning("Host bereits initialisiert");
            s_host.Dispose();
        }

        var builder = new HostBuilder()
            .ConfigureServices((hostContext, services) =>
            {
                services.AddWindowsFormsBlazorWebView();
                services.AddBlazorWebView();
                services.AddLogging(configure => configure.AddConsole());
                services.AddTransient(typeof(Form), startFormType);
            });

        var host = builder.Build();
        Application.ApplicationExit += (sender, args) => host.Dispose();

        s_host = new WinFormsHost(host, colorMode, visualStylesMode);
        return (WinFormsHost)s_host;
    }

    /// <summary>
    /// Startet den WinForms-Host asynchron.
    /// </summary>
    /// <param name="cancellationToken">Das Abbruchtoken.</param>
    /// <returns>Ein <see cref="Task"/>, das die asynchrone Operation darstellt.</returns>
    public Task StartAsync(CancellationToken cancellationToken = default)
    {
        // Application.SetColorMode(_colorMode);
        Application.SetDefaultVisualStylesMode(_visualStylesMode);

        var form = Services.GetRequiredService<Form>();
        Application.Run(form);

        return Task.CompletedTask;
    }

    /// <summary>
    /// Stoppt den WinForms-Host asynchron.
    /// </summary>
    /// <param name="cancellationToken">Das Abbruchtoken.</param>
    /// <returns>Ein <see cref="Task"/>, das die asynchrone Operation darstellt.</returns>
    public Task StopAsync(CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Gibt die von <see cref="WinFormsHost"/> verwendeten Ressourcen frei.
    /// </summary>
    /// <param name="disposing">Ein Wert, der angibt, ob das Objekt freigegeben wird.</param>
    protected virtual void Dispose(bool disposing)
    {
        if (!disposedValue)
        {
            if (disposing)
            {
                _innerHost.Dispose();
            }

            disposedValue = true;
        }
    }

    /// <summary>
    /// Gibt die von <see cref="WinFormsHost"/> verwendeten Ressourcen frei.
    /// </summary>
    public void Dispose()
    {
        // Ändern Sie diesen Code nicht.
        // Fügen Sie den Bereinigungscode in der Methode 'Dispose(bool disposing)' ein.
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }
}
