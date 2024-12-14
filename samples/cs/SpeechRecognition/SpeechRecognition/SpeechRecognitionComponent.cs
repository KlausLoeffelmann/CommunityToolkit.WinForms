using System.ComponentModel;
using Windows.Media.SpeechRecognition;

using SDKTemplate;
using Windows.Globalization;

namespace SpeechRecognition;

public partial class SpeechRecognitionComponent : Component
{
    private readonly SpeechRecognizer recognizer;

    public SpeechRecognitionComponent()
    {
        recognizer = new SpeechRecognizer();
    }

    public static async Task<bool> GetPermissionsAsync()
    {
        // Prompt the user for permission to access the microphone. This request will only happen
        // once, it will not re-prompt if the user rejects the permission.
        bool permission = await AudioCapturePermissions.RequestMicrophonePermission();
        var accessStatus = await SpeechRecognizer.TrySetSystemSpeechLanguageAsync(new Language("en-US"));

        return permission;

    }

    public async Task<string> StartListeningAsync()
    {
        try
        {
            // Ensure microphone permissions are granted
            bool hasPermission = await GetPermissionsAsync();
            if (!hasPermission)
            {
                Console.WriteLine("Microphone permission denied.");
                return string.Empty;
            }

            // Compile constraints
            var compilationResult = await recognizer.CompileConstraintsAsync();
            if (compilationResult.Status != SpeechRecognitionResultStatus.Success)
            {
                Console.WriteLine("Failed to compile constraints.");
                return string.Empty;
            }

            // Start recognition
            SpeechRecognitionResult result = await recognizer.RecognizeAsync();
            if (result.Status == SpeechRecognitionResultStatus.Success)
            {
                return result.Text;
            }
            else
            {
                Console.WriteLine($"Recognition failed with status: {result.Status}");
                return string.Empty;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return string.Empty;
        }
    }
}
