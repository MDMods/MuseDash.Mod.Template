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
        SettingManager.Load();
        LoggerInstance.Msg($"{Name} is loaded!");
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