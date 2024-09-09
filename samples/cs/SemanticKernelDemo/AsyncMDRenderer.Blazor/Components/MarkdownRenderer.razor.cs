using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace AsyncMDRenderer.Blazor.Components;

public partial class MarkdownRenderer : ComponentBase
{
    [Inject] IJSRuntime JSRuntime { get; set; } = default!;

    private string _markdownContent = string.Empty;

    [JSInvokable("RenderMarkdown")]
    public Task RenderMarkdown(string markdown)
    {
        _markdownContent += markdown;
        InvokeAsync(StateHasChanged); // Re-render the component

        return Task.CompletedTask;
    }
}
