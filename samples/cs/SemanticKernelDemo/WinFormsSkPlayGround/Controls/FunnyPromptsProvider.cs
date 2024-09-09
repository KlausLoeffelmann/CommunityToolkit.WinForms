namespace SemanticKernelDemo.Controls;

public static class FunnyPromptsProvider
{
    private static readonly string[] s_prompts = new[]
    {
        "Write a breakup letter from a coffee cup to a teapot.",
        "Explain the plot of Inception as if you are a 5-year-old trying to explain a dream you had.",
        "If cats were the dominant species, what would their government look like?",
        "Translate this common phrase into pirate speak: 'Can I get a refund?'",
        "Write a job advertisement for a dragon who needs a personal assistant.",
        "What would Shakespeare's Tinder profile look like?",
        "Convince me, using only facts about cheese, that the moon landing was fake.",
        "If unicorns were real, how would they deal with climate change?",
        "Describe the world's worst superhero and their equally terrible superpower.",
        "Imagine if socks could talk. Write a dialogue between two socks that were separated in the laundry.",
        "What would an instruction manual for a 'reverse microwave' look like?",
        "Design a theme park attraction based on the experience of waiting in line at the DMV.",
        "Write a Yelp review from a vampire who went to a garlic-themed restaurant by mistake.",
        "Create a recipe for a 'Midnight Snack Sandwich' that no one in their right mind would eat.",
        "Explain quantum physics using the analogy of a pizza party gone horribly wrong."
    };

    /// <summary>
    /// Returns a random funny prompt.
    /// </summary>
    /// <returns>A random string containing a funny prompt.</returns>
    public static string GetRandomPrompt()
    {
        var random = new Random();
        return s_prompts[random.Next(s_prompts.Length)];
    }

    /// <summary>
    /// Returns all available funny prompts.
    /// </summary>
    /// <returns>An array of strings containing all funny prompts.</returns>
    public static string[] GetAllPrompts() => s_prompts;
}
