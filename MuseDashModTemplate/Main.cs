namespace MuseDashModTemplate;

internal class Main : MelonMod
{
    // The method called when mod is loaded
    public override void OnInitializeMelon()
    {
        LoggerInstance.Msg($"{Name} is loaded!");
#if Setting
        SettingManager.Load();
#endif
    }

    // The method called when mod is unloaded
    public override void OnDeinitializeMelon()
    {
#if Setting
        SettingManager.Save();
#endif
    }
}