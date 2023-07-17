using Tomlet.Attributes;

namespace MuseDashModTemplate;

internal static class Setting
{
    internal static void Load()
    {
    }

    internal static void Save()
    {
    }
}

public class Data
{
    [TomlPrecedingComment("Example Bool")]
    internal readonly bool ExampleBool;

    [TomlPrecedingComment("Example Int")]
    internal readonly int ExampleInt;

    [TomlPrecedingComment("Example String")]
    internal readonly string ExampleString;

    // Constructor for MelonLoader to Deserialize the Data
    public Data()
    {
    }

    internal Data(bool exampleBool, string exampleString, int exampleInt)
    {
        ExampleBool = exampleBool;
        ExampleString = exampleString;
        ExampleInt = exampleInt;
    }
}