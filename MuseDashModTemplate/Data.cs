using Tomlet.Attributes;

namespace MuseDashModTemplate;

// Data class for the Mod
public class Data
{
    // TomlPrecedingComment is used to add a comment to the top of the field when the file is saved
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