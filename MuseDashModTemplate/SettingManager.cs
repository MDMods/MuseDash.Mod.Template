#if TomletSetting
using Tomlet;
#endif

#if MelonSetting
using MelonLoader;
#endif


namespace MuseDashModTemplate;

internal static class SettingManager
{
#if TomletSetting
    private static readonly string ConfigPath = Path.Combine("UserData", $"{Name}.cfg");
    internal static Data Setting { get; set; } = new();

    internal static void Load()
    {
        if (!File.Exists(ConfigPath))
        {
            var defaultConfig = TomletMain.TomlStringFrom(Setting);
            File.WriteAllText(ConfigPath, defaultConfig);
        }

        var setting = File.ReadAllText(ConfigPath);
        Setting = TomletMain.To<Data>(setting);
    }

    internal static void Save()
    {
        File.WriteAllText(ConfigPath, TomletMain.TomlStringFrom(Setting));
    }
#endif

#if MelonSetting
    private static MelonPreferences_Entry<bool> _exampleBool;
    private static MelonPreferences_Entry<int> _exampleInt;
    private static MelonPreferences_Entry<string> _exampleString;
    public static bool ExampleBool => _exampleBool.Value;
    public static bool ExampleInt => _exampleInt.Value;
    public static string ExampleString => _exampleString.Value;


    internal static void Register()
    {
        var category = MelonPreferences.CreateCategory($"{Name}", $"{Name}");

        _exampleBool = category.CreateEntry("ExampleBool", false, "Example Bool");
        _exampleInt = category.CreateEntry("ExampleInt", 1, "Example Int");
        _exampleString = category.CreateEntry("ExampleString", "String", "Example String");
    }
#endif
}