using MelonLoader;

namespace MuseDashModTemplate;

public class Main : MelonMod
{
    // The method called when mod is loaded
    public override void OnInitializeMelon()
    {
        LoggerInstance.Msg("MuseDashModTemplate is loaded!");
        Setting.Load();
    }

    // The method called when mod is unloaded
    public override void OnDeinitializeMelon()
    {
        Setting.Save();
    }
}