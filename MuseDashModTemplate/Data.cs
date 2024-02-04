using Tomlet.Attributes;

namespace MuseDashModTemplate;

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