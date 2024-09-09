namespace SemanticKernelDemo.Controls;

public delegate Task AsyncEventHandler(object? sender, EventArgs e);

public class AsyncButton : Button
{
    public event AsyncEventHandler? AsyncClick;

    protected async override void OnClick(EventArgs e)
    {
        base.OnClick(e);

        if (AsyncClick is null)
            return;

        // Invoke each handler safely
        foreach (AsyncEventHandler handler in AsyncClick.GetInvocationList().Cast<AsyncEventHandler>())
        {
            try
            {
                await handler.Invoke(this, e).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                Application.OnThreadException(ex);
            }
        }
    }
}
