using CommunityToolkit.WinForms.Controls;
using CommunityToolkit.WinForms.Extensions;
using System.Text.Json;

namespace WinFormsSkPlayGround.Views;

public partial class LearnGermanDemo
{
    // Demonstrates how to use the AI Text Formatter Component to translate German to English.
    private async Task BtnDoubleProcess_AsyncClick(object sender, EventArgs e)
    {
        _skComponent.ApiKeyGetter = () => Environment.GetEnvironmentVariable(OpenAiApiKeyLookupKey)
            ?? throw new InvalidOperationException("The AI:OpenAI:ApiKey environment variable is not set.");

        // Set the Model parameters to values which increases predictability.
        _skComponent.Temperature = 0.0;
        _skComponent.TopP = 0.7;
        _skComponent.FrequencyPenalty = 0.0;
        _skComponent.PresencePenalty = -1;
        _skComponent.LogConsole = _parentForm.FirstDescendantOrDefault<ConsoleControl>();

        _skComponent.SystemPrompt = SystemPrompt;

        // This is the schema we want:
        // The PhoneticEnglish and EnglishTranslation are required.
        _skComponent.JsonSchema =
            """
            {
              "$schema": "http://json-schema.org/draft-07/schema#",
              "type": "object",
              "properties": {
                "PhoneticEnglish": {
                  "type": "string"
                },
                "EnglishTranslation": {
                  "type": "string"
                }
              },
              "required": ["PhoneticEnglish", "EnglishTranslation"],
              "additionalProperties": false
            }
            """;

        // That's supposed to be Json data now.
        string? jsonData = await _skComponent.RequestTextPromptResponseAsync(_txtGermanTextPrompt.Text, false);

        if (jsonData is null)
        {
            _tslEnglishTranslation.Text = "**** We couldn't get any data back.";

            return;
        }

        // We deserialize and put the data in the UI.
        TranslationReturnValues? translationReturnValues = JsonSerializer.Deserialize<TranslationReturnValues>(jsonData);

        await InvokeAsync(() =>
        {
            _tslEnglishTranslation.Text = translationReturnValues?.EnglishTranslation ?? "**** We couldn't get any data back.";
            _txtPhoneticEnglish.Text = translationReturnValues?.PhoneticEnglish;
        });
    }

    public class TranslationReturnValues
    {
        public string PhoneticEnglish { get; set; } = string.Empty;
        public string EnglishTranslation { get; set; } = string.Empty;
    }
}
