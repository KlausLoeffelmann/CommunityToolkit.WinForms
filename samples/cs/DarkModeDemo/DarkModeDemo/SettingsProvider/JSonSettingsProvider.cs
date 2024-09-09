using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;

namespace DarkModeDemo.SettingsProvider;

public class DynamicSettings
{
    private readonly string _settingsFilePath;
    private Dictionary<string, string> _settings = [];

    private const string _settingsFileName = "settings.json";
    private const string _appDataName = "DarkModeDemo";

    public static readonly DynamicSettings Instance = new();

    JsonSerializerSettings _jsonSerSettings = new()
    {
        TypeNameHandling = TypeNameHandling.Auto,
        Formatting = Formatting.Indented,
        ObjectCreationHandling = ObjectCreationHandling.Replace,
    };

    private DynamicSettings()
    {
        string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        string appFolderPath = Path.Combine(appDataPath, _appDataName);
        Directory.CreateDirectory(appFolderPath);
        _settingsFilePath = Path.Combine(appFolderPath, _settingsFileName);
    }

    private object this[string key]
    {
        get
        {
            if (!_settings.TryGetValue(key, out string? value))
            {
                return null!;
            }

            return value;
        }

        set
        {
            if (value is null)
            {
                _settings.Remove(key);
            }
            else
            {
                _settings[key] = JsonConvert.SerializeObject(value, value.GetType(), _jsonSerSettings);
            }

            SaveSettings();
        }
    }

    public void SaveSettings()
    {
        var json = JsonConvert.SerializeObject(_settings, _jsonSerSettings);

        File.WriteAllText(_settingsFilePath, json);
    }

    public void LoadSettings()
    {
        if (File.Exists(_settingsFilePath))
        {
            var json = File.ReadAllText(_settingsFilePath);

            _settings = JsonConvert.DeserializeObject<Dictionary<string, string>>(
                value: json,
                settings: _jsonSerSettings) 
                ?? [];
        }
    }

    public static void SetValue<T>(string key, T value)
    {
        Instance[key] = value!;
        Instance.SaveSettings();
    }

    public static T? GetValue<T>(string key)
    {
        if (!Instance._settings.TryGetValue(key, out string? value))
        {
            return default;
        }

        return JsonConvert.DeserializeObject<T>(
            value: value!,
            settings: Instance._jsonSerSettings)!;
    }
}
