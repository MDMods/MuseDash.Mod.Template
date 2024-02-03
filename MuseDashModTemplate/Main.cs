namespace MuseDashModTemplate;

internal class Main : MelonMod
{
    // The method called when mod is loaded
    public override void OnInitializeMelon()
    {
        LoggerInstance.Msg($"{Name} is loaded!");
        SettingManager.Load();
    }

    // The method called when mod is unloaded
    public override void OnDeinitializeMelon()
    {
        SettingManager.Save();
    }
}