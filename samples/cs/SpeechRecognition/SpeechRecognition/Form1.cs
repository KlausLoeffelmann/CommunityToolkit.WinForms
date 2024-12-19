using System.Runtime.CompilerServices;

namespace SpeechRecognition;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private async void Button_Click(object sender, EventArgs e)
    {
        await HandleButtonClickCommandAsync(sender, e);
    }

    [AsyncEventHandler(nameof(button1), nameof(Button.Click))]
    private async Task HandleButtonClickCommandAsync(object sender, EventArgs e)
    {
        SpeechRecognitionComponent component = new();

        bool hasPermissions = await SpeechRecognitionComponent.GetPermissionsAsync();
        string result = await component.StartListeningAsync();
        MessageBox.Show(result);
    }
}

public class AsyncEventHandlerAttribute(string controlName, string eventName) : Attribute
{
    public string EventName { get; } = eventName;
    public string ControlName { get; } = controlName;
}
