using System.Reflection;

namespace CommunityToolkit.WinForms.AI;
#pragma warning restore SKEXP0010 // Type is for evaluation purposes only and is subject to change or removal in future updates. Suppress this diagnostic to proceed.

public class StringSpellAndGrammarChecker : SemanticKernelComponent<string>
{
    protected override string GetAssistantInstructions()
    {
        // The Assistant-Instructions are in an MD file and setup to be compiled as an embedded resource.
        // We need to get the resource stream and read the content:
        Assembly assembly = typeof(StringSpellAndGrammarChecker).Assembly;
        using Stream stream = assembly.GetManifestResourceStream($"{nameof(StringSpellAndGrammarChecker)}.AssistantInstructions.md")!;
        using StreamReader reader = new(stream);

        return reader.ReadToEnd();
    }

    public async Task<string?> CheckSpellingAndGrammar(string textToCheck)
    {
        return await RequestPromptProcessingAsync("CheckSpellingAndGrammar", textToCheck);
    }
}
