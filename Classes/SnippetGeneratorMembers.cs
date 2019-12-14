using System;
using System.Collections.Generic;
using System.Text;

namespace SnippetGenerator.Classes
{
    class SnippetGeneratorMembers
    {

    }

    //struct ClassGeneratorMembers
    //{

    //}

    public struct Types
    {
        public const string Class = "Class";
        public const string Interface = "Interface";
    }

    public enum FileStatusType
    {
        Notsaved = 0,
        Saved = 1
    }

    public static class GeneratorConstants
    {
        public static string NewLine = "\n";
        public static string Tab = "\t";
        public static string NewlineTab = "\n\t";
        public static string TabNewline = "\t\n";
        public static string CarriageReturn = "\r";
    }

    public struct ABC
    {

    }
    [Flags]
    [Obsolete]
    [Serializable]
    public enum Days
    {
        Sun = 1,
        Mon = 2,
        Tue = 3,
        Wed = 4,
        Thu = 5,
        Fri = 6,
        Sat = 7
    }

}

internal class MyClass
{
    protected internal static bool bChecked = false;
}
internal static class SClass
{
}
