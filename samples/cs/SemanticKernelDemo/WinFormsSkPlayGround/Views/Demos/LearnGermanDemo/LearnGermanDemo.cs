﻿using CommunityToolkit.WinForms.AI;
using CommunityToolkit.WinForms.Extensions;
using Microsoft.CognitiveServices.Speech;
using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.ChatCompletion;
using Microsoft.SemanticKernel.Connectors.OpenAI;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace WinFormsSkPlayGround.Views;

[ToolboxBitmap(typeof(LearnGermanDemo), "MvvmView.bmp")]
public partial class LearnGermanDemo : UserControl
{
    // Keys for looking up the API keys via environment variables.
    private const string OpenAiApiKeyLookupKey = "AI:OpenAi:ApiKey";

    private const string AzureSpeechSubscriptionKeyLookupKey = "AzureSpeech:SubscriptionKey";
    private const string AzureSpeechSubscriptionRegionLookupKey = "AzureSpeech:Region";

    private static readonly char[] s_separators = [' ', '-', ',', '.', '?', '!'];

    // This is the system prompt that will be used for the OpenAI model execution.
    private const string SystemPrompt =
        """
        You are an assistant for helping someone to get German pronunciation right.

        Translate the following German text into 'Phonetic English', using phonetic spelling 
        so that the English words sound as close as possible to the original German 
        words when spoken aloud.

        Here are the principle rules:
        * Use dashes for only longer words, for example "min-oo-ten" for "Minuten", or "Hoaf-broy-house" for "Hoaf-broy-house"!
        * Treat 'ch' as in 'ich' as "sh". Samples: 'ich' becomes 'ish', 'mich' becomes 'mish'.
        * Be careful with conversion of German "i" - it should be pronounced as "ee" in English. 
          For example, "Bier" becomes "beer", and 'Fische' should be 'feshe' not 'fi-she'.
        * Use "uh" for the German "a" sound: "Bavaria" becomes "Buh-vuh-ree-uh".
        * Use "ai" for the German "ei" sound: "Zwei" (or 2) becomes "Tswai". "Ein" becomes "Ain". "Eine" become "ain-eh".
        * Use "ee" for the German "ie" sound: "Sie" becomes "See".
        * Use "oi" for the German "eu"-sound: "Heute" becomes "Hoyteh". "99" becomes "Noin-uhnd-noin-zig".
        * Transform the German past participle prefix "ge" to "geh-".
        * Do not use "öäü" in phonetic spelling, and do not convert them to "oe ae ue".
          * "für" becomes "fur".
          * "völlig" becomes "fellick".
          * "Müller" becomes "Muller".
          * "Schwäche" becomes "shvasheh".
        * Combine and generalize those rules, when it make sense: For example "Dafür" becomes "Duhfur".
          
        * Bavarian dialect words should be written in a way that reflects their pronunciation. Here are the most important:
          * Servus -> Zair-voos
          * Oachkatzlschwoaf -> Owkh-khatzl-shwawf
          * Griaß di -> Gree-ass dee
          * Brez’n -> Bret-zn
          * Schee -> Shay
          * Gsuffa -> Gsoofa
          * Basst scho -> Bahst show
          * A G’schicht -> Auh guh-shickht
          * Heast -> Hay-ast
          * A Bierle -> Uh bee-ur-le
          * Schmarrn -> Shmahrn
          * Ois Guade -> Oys goo-uh-de
          * Spatzl -> Shpat-zl
          * Buam -> Boo-ahm
          * Wurscht -> Vursht
          * Oans -> Uhns
          * Zwoa -> Zwa

        * If a word is a number, you should write it out, so "1" becomes "ains", "ain" or "ain-eh", depending on the context.
        """;

    private StatusStrip? _statusStrip;

    // The chat history. If you are using ChatGPT for example directly in the WebBrowser,
    // this equals the chat history, so, the things you've said and the responses you've received.
    private ChatHistory? _chatHistory;

    // The kernel for the Semantic Kernel scenario. It bundles the connectors and services.
    private Kernel? _kernel;
    private readonly Form _parentForm;

    [AllowNull]
    private ToolStripItem _tslTimeElapsed;

    [AllowNull]
    private ToolStripItem _tslEnglishTranslation;

    public LearnGermanDemo(Form parentForm)
    {
        ArgumentNullException.ThrowIfNull(parentForm);
        _parentForm = parentForm;

        InitializeComponent();

        _cmbDeutscheTextBeispiele.SelectedIndexChanged +=
            (s, e) => _txtGermanTextPrompt.Text = _cmbDeutscheTextBeispiele.Text;
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);

        _statusStrip = _parentForm.FirstDescendant<StatusStrip>();

        _ = _statusStrip.Items.Add("Kernel-API call time: ");
        _tslTimeElapsed = _statusStrip.Items.Add(string.Empty);
        _tslEnglishTranslation = _statusStrip.Items.Add(string.Empty);
    }

    // This is the method that will translate the German text into "phonetic English."
    private async Task BtnAsyncPhoneticTranslate_AsyncClick(object sender, EventArgs e)
    {
        string germanText = _txtGermanTextPrompt.Text;

        await InvokeAsync(() => _txtPhoneticEnglish.Clear());

        string apiKey = Environment.GetEnvironmentVariable(OpenAiApiKeyLookupKey)
            ?? throw new InvalidOperationException("The AI:OpenAI:ApiKey environment variable is not set.");

        // We're using the GPT-4o model from OpenAI directory for our Semantic Kernel scenario.
        if (_kernel is null)
        {
            var kernelBuilder = Kernel
                .CreateBuilder()
                .AddOpenAIChatCompletion("gpt-4o", apiKey);

            _kernel = kernelBuilder.Build();
        }

        _chatHistory ??= [];

        OpenAIPromptExecutionSettings executionSettings = new();
        executionSettings
            .WithSystemPrompt(SystemPrompt)
            .WithDefaultModelParameters(temperature: 0.1);

        var chatService = _kernel.GetRequiredService<IChatCompletionService>();

        _chatHistory.AddUserMessage(_txtGermanTextPrompt.Text);

        Stopwatch stopwatch = Stopwatch.StartNew();

        var responses = await chatService.GetChatMessageContentsAsync(
            _chatHistory,
            kernel: _kernel,
            executionSettings: executionSettings);

        stopwatch.Stop();

        await InvokeAsync(
            () => _tslTimeElapsed.Text = $"{stopwatch.ElapsedMilliseconds:#,###} ms.");

        StringBuilder responseStringBuilder = new();

        // We can have several responses, so we'll append them all to the text box.
        // But we need to also add them to the chat history!
        foreach (ChatMessageContent response in responses)
        {
            _chatHistory.AddMessage(response.Role, response.ToString());
            responseStringBuilder.Append(response);

            await _txtPhoneticEnglish.InvokeAsync(() =>
            {
                _txtPhoneticEnglish.AppendText(response.ToString());
                _txtPhoneticEnglish.ScrollToCaret();
            });
        }
    }

    // This is the method that will read the phonetic English out loud.
    private async Task BtnAsyncReadPhoneticEnglishOutLoud_AsyncClick(object sender, EventArgs e)
    {
        string subscriptionKey = Environment.GetEnvironmentVariable(AzureSpeechSubscriptionKeyLookupKey)
            ?? throw new InvalidOperationException("The Speech:SubscriptionKey environment variable is not set.");

        string subscriptionRegion = Environment.GetEnvironmentVariable(AzureSpeechSubscriptionRegionLookupKey)
            ?? throw new InvalidOperationException("The Speech:SubscriptionRegion environment variable is not set.");

        // Creates an instance of a speech config with specified subscription key and service region.
        var config = SpeechConfig.FromSubscription(subscriptionKey, subscriptionRegion);
        config.SpeechSynthesisVoiceName = "en-US-AshleyNeural";

        // That's the text, we're supposed to speak.
        string text = _txtPhoneticEnglish.Text;
        text = AddSsmlAttributesToPreventSpelling(text);

        using var synthesizer = new SpeechSynthesizer(config);

        string ssmlText = $"""
            <speak version="1.0" xmlns="http://www.w3.org/2001/10/synthesis" xml:lang="en-US">
                <voice name="en-US-AshleyNeural">
                    {text}
                </voice>
            </speak>
            """;

        using var result = await synthesizer.SpeakSsmlAsync(ssmlText);

        if (result.Reason == ResultReason.SynthesizingAudioCompleted)
        {
            Console.WriteLine($"Speech synthesized for text [{text}]");
        }
        else if (result.Reason == ResultReason.Canceled)
        {
            var cancellation = SpeechSynthesisCancellationDetails.FromResult(result);
            Console.WriteLine($"CANCELED: Reason={cancellation.Reason}");

            if (cancellation.Reason == CancellationReason.Error)
            {
                Console.WriteLine($"CANCELED: ErrorCode={cancellation.ErrorCode}");
                Console.WriteLine($"CANCELED: ErrorDetails=[{cancellation.ErrorDetails}]");
                Console.WriteLine($"CANCELED: Did you update the subscription info?");
            }
        }

        string AddSsmlAttributesToPreventSpelling(string input)
        {
            ReadOnlySpan<char> span = input.AsSpan();
            StringBuilder sb = new();

            int start = 0;

            for (int i = 0; i < span.Length; i++)
            {
                char c = span[i];

                if (s_separators.Any((chr) => chr == c))
                {
                    if (start < i)
                    {
                        // Wrap the word or syllable in <say-as> tags
                        sb.Append("<say-as interpret-as=\"name\">");
                        sb.Append(span[start..i]);
                        sb.Append("</say-as>");
                    }

                    // Append the separator character only if it's not a dash.
                    if (span[i] != '-') sb.Append(span[i]);
                    start = i + 1;
                }
            }

            // Append the last part if there's any remaining text after the loop
            if (start < span.Length)
            {
                sb.Append("<say-as interpret-as=\"name\">");
                sb.Append(span[start..]);
                sb.Append("</say-as>");
            }

            return sb.ToString();
        }
    }
}
