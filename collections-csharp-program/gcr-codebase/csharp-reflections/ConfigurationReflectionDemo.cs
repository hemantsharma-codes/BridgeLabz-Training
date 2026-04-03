using System;
using System.Reflection;

class ConfigurationReflectionDemo
{
    private static string API_KEY = "OLD_KEY";

    static void Main(string[] args)
    {
        Type type = typeof(ConfigurationReflectionDemo);
        FieldInfo field = type.GetField("API_KEY", BindingFlags.Static | BindingFlags.NonPublic);

        field.SetValue(null, "NEW_KEY");

        Console.WriteLine(field.GetValue(null));
    }
}
