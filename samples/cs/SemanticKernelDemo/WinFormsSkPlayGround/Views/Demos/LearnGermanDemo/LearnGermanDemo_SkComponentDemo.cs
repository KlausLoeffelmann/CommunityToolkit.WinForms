using System.Text.Json;

namespace WinFormsSkPlayGround.Views;

public partial class LearnGermanDemo
{
    // Demonstrates how to use the AI Text Formatter Component to translate German to English.
    private async Task BtnDoubleProcess_AsyncClick(object sender, EventArgs e)
    {
        _skComponent.ApiKeyGetter = () => Environment.GetEnvironmentVariable(OpenAiApiKeyLookupKey)
            ?? throw new InvalidOperationException("The AI:OpenAI:ApiKey environment variable is not set.");

        _skComponent.SystemPrompt = SystemPrompt;
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

        string? jsonData = await _skComponent.RequestTextPromptResponseAsync(_txtGermanTextPrompt.Text);

        if (jsonData is null)
        {
            _tslEnglishTranslation.Text = "**** We couldn't get any data back.";

            return;
        }

        TranslationReturnValues? translationReturnValues = JsonSerializer.Deserialize<TranslationReturnValues>(jsonData);
        _tslEnglishTranslation.Text = translationReturnValues?.EnglishTranslation ?? "**** We couldn't get any data back.";
        _txtPhoneticEnglish.Text = translationReturnValues?.PhoneticEnglish;
    }

    public class TranslationReturnValues
    {
        public string PhoneticEnglish { get; set; } = string.Empty;
        public string EnglishTranslation { get; set; } = string.Empty;
    }
}
