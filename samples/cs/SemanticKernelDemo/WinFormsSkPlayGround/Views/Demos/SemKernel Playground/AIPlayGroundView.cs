﻿using SemanticKernelDemo.Controls;
using static WinFormsSkPlayGround.Properties.Resources;

namespace WinFormsSkPlayGround.Views;

[ToolboxBitmap(typeof(AIPlayGroundView), "MvvmView.bmp")]
public partial class AIPlayGroundView : UserControl
{
    public AIPlayGroundView()
    {
        InitializeComponent();

        // Wiring the delegate which provides the Open AI ApiKey when we need it:
        _semanticKernelCommunicator.ApiKeyGetter =
            () => Environment.GetEnvironmentVariable(ApiKeyEnvironmentVarLookup)
                ?? throw new NullReferenceException("Could not retrieve Open AI ApiKey.");

        // Setting up the "personality" ComboBox:
        _cmbPersonalities.Items.AddRange([.. s_personalities.Keys]);

        // Preselect the first personality once the form has completely loaded:
        Load += (s, e) => _cmbPersonalities.SelectedIndex = 0;

        // Handle changing the personalities:
        _cmbPersonalities.SelectedIndexChanged += (s, e) =>
        {
            // Lookup the selected personality:
            string selectedPersonality = _cmbPersonalities.SelectedItem as string 
                ?? throw new NullReferenceException("Personality disorder exception!");

            _semanticKernelCommunicator.SystemPrompt = s_personalities[selectedPersonality];
        };
    }

    internal void RequestBrowserTools() =>
        _conversationView.WebView.CoreWebView2.OpenDevToolsWindow();

    private async Task PromptControl_AsyncSendPrompt(object sender, EventArgs e)
    {
        string textToSend = _promptControl.Text;
        _promptControl.Clear();

        _conversationView.AddConversationItem(textToSend, isResponse: false);

        var responses = _conversationView.UpdateCurrentResponseAsync(
            asyncEnumerable: _semanticKernelCommunicator.RequestPromptResponseStreamAsync(textToSend, true));

        // If you wanted to examine the responses one by one, here's how you could do it:
        await foreach (var response in responses)
        {
            if (response is null)
            {
                continue;
            }
        }
    }

    private async void PromptControl_NewPromptSuggestionRequest(object sender, EventArgs e)
    {
        string funnyRandomPrompt = FunnyPromptsProvider.GetRandomPrompt();
        _promptControl.Text = funnyRandomPrompt;

        // We use a "side-affect" of InvokeAsync to schedule this,
        // so that the text is set _before_ we select it.
        await _promptControl.InvokeAsync(() => _promptControl.SelectAll());
    }

    private void BtnClearHistory_Click(object sender, EventArgs e)
    { 
        _conversationView.ClearHistory();
        _semanticKernelCommunicator?.ChatHistory?.Clear();
    }

    private static readonly Dictionary<string, string> s_personalities = new()
    {
        {
            "Default",
            "You are a friendly, versatile Assistant, trying to address all requests to the best of your abilities, "
          + "and you are engaged, even if folks just want to chat. But you politely decline requests that are inappropriate or impolite."
        },
        {
            "Funny/Ironic",
            "You are a witty and ironic Assistant, always ready with a playful quip or punchline. Provide helpful answers, "
          + "but pepper them with dry humor or lighthearted irony. Keep responses fun, yet respectful."
        },
        {
            "C#/VB Coding Assistant",
            "You are a specialized Coding Assistant for VB and C#. You handle these topics with expertise and "
          + "politely decline or redirect any non-C#/VB topics."
        },
        {
            "Shakespearean",
            "You are a Shakespearean bard. Speak in the style of Elizabethan English, employing flowery prose and "
          + "theatrical flourishes when you respond, yet strive to remain clear in your meaning."
        },
        {
            "Sarcastic/Grumpy",
            "You are sarcastic and even funny-grumpy. You answer questions directly, but with a hint of annoyance or a sarcastic quip. "
          + "Keep the humor gentle—don’t cross the line into being offensive, but definitely be sassy!"
        },
        {
            "Translate to Klingon",
            "You are a Klingon translator. Try to provide a valid translation into Klingon, "
          + "and add comments on to best pronounce it or that the entered phrased had to be paraphrased."
          + "Please return the actual translated phrase in bold and italic, and additional explanations in a standard font."
        }
    };
}