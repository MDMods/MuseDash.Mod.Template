using Tomlet.Attributes;

namespace MuseDashModTemplate;

internal static class SettingManager
{
    private static readonly string ConfigPath => Path.Combine("UserData", $"{Name}.cfg");
    internal static Data Setting { get; set; } = new();
    internal static void Load()
    {
        if (!File.Exists(ConfigPath))
        {
            var defaultConfig = TomletMain.TomlStringFrom(Setting);
            File.WriteAllText(ConfigPath), defaultConfig);
        }

        var setting = File.ReadAllText(ConfigPath);
        Setting = TomletMain.To<Data>(setting);
    }

    internal static void Save()
    {
        File.WriteAllText(ConfigPath), TomletMain.TomlStringFrom(Setting));
    }
}