using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using System.Text.Json;

namespace CommunityToolkit.WinForms.Controls.Blazor;

public partial class ConversationViewModel(string headline, string backColor, string foreColor, string newItemsBackColor)
    : ObservableObject
{
    private static readonly string s_sampleMarkdown =
            """
            # This is the headline

            This is a paragraph with some **bold** and *italic* text. This is a [link](https://www.bing.com).
            And this is some more text, namely bullet points:

            * This is the first bullet point. And it is not only a small one: It is a very long one, that spans
              multiple lines. This is the first line. And this is the second line. And this is the third line.
            * This is the second bullet point. Again, it is not only a small one: It is a very long one, that spans
              multiple lines. This is the first line. And this is the second line. And this is the third line.

            ## This is a second header headline

            And now comes the typical Lorem Ipsum text:

            Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et 
            dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip 
            ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu 
            fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt 
            mollit anim id est laborum.

            Lass uns das auf Deutsch versuchen:

            Quorum ipsum dolor sitzen am Platz, konsequenter Adaption elitär, noch du euismod temporäre Inzidenz 
            bei Arbeiten und Schmerzen magna aliqua. Um nämlich ad minimale Erlaubnis, wer möchte Übung großzügig 
            arbeiten, ohne dass einige Entlastung von dies angenehm Folgen. Durch aute Irrtum Schmerzen in der 
            Verantwortung in Freude wollen diese kleine Schmerz ich fliehe keine Genuss, sondern fortzufahren, 
            Cupidität nicht verantwortlich, sind in der Schuld die offizielle Verantwortlichen anim ist diese Arbeit.
            """;

    [ObservableProperty]
    private string _backColor = backColor;

    [ObservableProperty]
    private string _foreColor = foreColor;

    [ObservableProperty]
    private string _headline = headline;

    [ObservableProperty]
    private string? _responseInProgress;

    [ObservableProperty]
    private string? _responseInProgressBackColor = newItemsBackColor;

    [ObservableProperty]
    private ObservableCollection<ConversationItemViewModel> _conversationItems = [];

    public void WriteJSon(Stream stream)
    {
        JsonWriterOptions options = new() 
        { 
            Indented = true,
        };

        // Let's use System.Text.Json to serialize the object:
        using Utf8JsonWriter writer = new(stream, options);

        writer.WriteStartObject();
        writer.WriteString(nameof(BackColor), BackColor);
        writer.WriteString(nameof(ForeColor), ForeColor);
        writer.WriteString(nameof(Headline), Headline);

        writer.WriteStartArray(nameof(ConversationItems));

        foreach (ConversationItemViewModel item in ConversationItems)
        {
            writer.WriteStartObject();
            item.WriteJSon(writer);
            writer.WriteEndObject();
        }

        writer.WriteEndArray();
        writer.WriteEndObject();
    }

    public static ConversationViewModel FromJSon(Stream stream)
    {
        using JsonDocument document = JsonDocument.Parse(stream);
        JsonElement root = document.RootElement;

        string headline = root.GetProperty(nameof(Headline)).GetString() ?? string.Empty;
        string backColor = root.GetProperty(nameof(BackColor)).GetString() ?? string.Empty;
        string foreColor = root.GetProperty(nameof(ForeColor)).GetString() ?? string.Empty;

        // Assuming newItemsBackColor is available or set to a default value
        string newItemsBackColor = string.Empty;

        var conversationViewModel = new ConversationViewModel(headline, backColor, foreColor, newItemsBackColor);

        if (root.TryGetProperty(nameof(ConversationItems), out JsonElement conversationItemsElement))
        {
            foreach (JsonElement itemElement in conversationItemsElement.EnumerateArray())
            {
                var item = ConversationItemViewModel.FromJsonElement(itemElement);
                conversationViewModel.ConversationItems.Add(item);
            }
        }

        return conversationViewModel;
    }
}
