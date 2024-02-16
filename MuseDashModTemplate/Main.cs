namespace MuseDashModTemplate;

internal class Main : MelonMod
{
    // The method called when mod is loaded
    public override void OnInitializeMelon()
    {
#if MelonSetting
        SettingManager.Register();
#endif
#if TomletSetting
        LoggerInstance.Msg($"{Name} is loaded!");
        SettingManager.Load();
#endif
    }

    // The method called when mod is unloaded
    public override void OnDeinitializeMelon()
    {
#if TomletSetting
        SettingManager.Save();
#endif
    }
}