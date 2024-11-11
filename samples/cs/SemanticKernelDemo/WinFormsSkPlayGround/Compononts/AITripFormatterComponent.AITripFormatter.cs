using CommunityToolkit.WinForms.AI;
using CommunityToolkit.WinForms.TypedInputExtenders;
using System.ComponentModel;
using System.Text.Json;

namespace WinFormsSkPlayGround.Components;

public partial class AITripFormatterComponent
{
    public class AITripFormatter : TypedFormatter<string?>
    {
        private const string OpenAiApiKeyLookupKey = "AI:OpenAi:ApiKey";
        private readonly SemanticKernelComponent _skComponent = new();

        protected const string SystemPrompt =
        """
        You are helping in one entry field of a Form for driver's log app to correct the trip's stop-overs, start and destination location names.
        Since we assume you do not have access to the internet, rely on the information you have in your head.
        You are given the following information:

        * Home country or state: Example: "Germany" or "Washington/USA"
        * Home town: Example: "Lippstadt" or "Redmond"
        * The user's input which is supposed to be a list of start/end locations and stop-overs.
        * Sample 1: "Lippstadt - Paderborn - Bielefeld - Lippstadt". Output: "Start: Lippstadt, Stop-overs: Paderborn, Bielefeld, End: Lippstadt"
        * Sample 2: "Redmond - Seattle - Bellevue - Redmond". Output: "Start: Redmond, Stop-overs: Seattle, Bellevue, End: Redmond"
        * Sample 3: "Lippstat - Pderborn - Billefeld - Lippstdt". Output: "Start: Lippstadt, Stop-overs: Paderborn, Bielefeld, End: Lippstadt" - you corrected the typos.

        * You try to correct typos in the location names amd then order the locations correctly.
        * If you know the area, try to describe in which greater area it is, and the roughly distance and time for the trip. 
          Be brief. Return that in the TripMetaData field.

        Please return the data as Json and take the enclosed schema into account.
        """;

        [DefaultValue(null)]
        public string? TripMetaData { get; set; }

        [DefaultValue(null)]
        public string? HomeStateOrCountry { get; set; }

        [DefaultValue(null)]
        public string? HomeTown { get; set; }

        // Done on Got-Focus. We take the typed value, convert it to a string, and show it in the TextBox.
        public override Task<string?> ConvertToDisplayAsync(string? value, CancellationToken token)
            => Task.FromResult<string?>(value);

        // Done on Lost Focus/Validate. We take the user input (the string) and try to convert it into the target type.
        public override async Task<string?> ConvertToValueAsync(string? value, CancellationToken token)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return string.Empty;
            }

            _skComponent.ApiKeyGetter = () => Environment.GetEnvironmentVariable(OpenAiApiKeyLookupKey)
                ?? throw new InvalidOperationException("The AI:OpenAI:ApiKey environment variable is not set.");

            _skComponent.SystemPrompt = SystemPrompt;
            _skComponent.JsonSchema =
               """
                {
                  "$schema": "http://json-schema.org/draft-07/schema#",
                  "type": "object",
                  "properties": {
                    "CheckedTripStops": {
                      "type": "string",
                      "description": "The user's value after plausibility-checking."
                    },
                    "TripMetaData": {
                      "type": "string",
                      "description": "Brief information about the trip, rough estimation how long it takes and how far it is. Or a quick statement that the trip's stop-overs are not familiar."
                    },
                    "ReturnStatus": {
                      "type": "string",
                      "description": "Either 'OK' or a brief description of what went wrong."
                    }
                  },
                  "required": ["CheckedTripStops", "TripMetaData", "ReturnStatus"],
                  "additionalProperties": false
                }
                """;

            string request = $"The Home state or country is{HomeStateOrCountry}\n." +
                $"The home town is {HomeTown}.\n" +
                $"The user requested assistance for the following trip stops entry:\n" +
                $"{value}.";

            string? jsonData = await _skComponent.RequestTextPromptResponseAsync(request, false);
            AITripStopsReturnValues? tripStopsReturnValues = null;

            if (string.IsNullOrEmpty(jsonData))
            {
                throw new InvalidOperationException("Trying to parse the text input failed for unknown reasons.");
            }

            try
            {
                tripStopsReturnValues = JsonSerializer.Deserialize<AITripStopsReturnValues>(jsonData);
                if (tripStopsReturnValues is null)
                {
                    throw new InvalidOperationException("Trying to parse the text input failed for unknown reasons.");
                }

                if (tripStopsReturnValues.ReturnStatus != "OK")
                {
                    throw new FormatException($"When the encountered an error when parsing the input: {tripStopsReturnValues.ReturnStatus}");
                }
            }
            catch (Exception innerException)
            {
                if (innerException is FormatException)
                {
                    throw;
                }

                throw new FormatException("There was a problem processing the user input", innerException);
            }

            TripMetaData = tripStopsReturnValues.TripMetaData;
            return tripStopsReturnValues.CheckedTripStops;
        }

        // Helper class, which carries the structured return values from the AI.
        private class AITripStopsReturnValues
        {
            [Description("The users value after spell-checking and optional translation, when it wasn't in English.")]
            public string CheckedTripStops { get; set; } = string.Empty;

            [Description("A brief description of what needed to be corrected or brushed up.")]
            public string TripMetaData { get; set; } = string.Empty;

            [Description("Either 'OK' or a brief description of what went wrong.")]
            public string ReturnStatus { get; set; } = string.Empty;
        }

        // This is the method which produces the initial value for the TextBox.
        public override Task<string?> InitializeEditedValueAsync(string? value, CancellationToken token)
            => Task.FromResult<string?>(value);
    }
}

