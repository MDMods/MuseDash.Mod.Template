namespace MuseDashModTemplate.Patches;

[HarmonyPatch(typeof(Patch), nameof(Postfix))]
internal static class Patch
{
    private static void Prefix()
    {
    }

    private static void Postfix()
    {
    }
}