using System;
using System.Reflection;

class ImportantMethodDemo
{
    static void Main(string[] args)
    {
        MethodInfo[] methods = typeof(ImportantMethodDemo).GetMethods(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);

        foreach (MethodInfo method in methods)
        {
            object[] attributes = method.GetCustomAttributes(typeof(ImportantMethod), false);
            foreach (ImportantMethod info in attributes)
            {
                Console.WriteLine(method.Name);
                Console.WriteLine(info.Level);
            }
        }
    }

    [ImportantMethod]
    static void SaveData()
    {
        Console.WriteLine("Saving data");
    }

    [ImportantMethod("MEDIUM")]
    static void LoadData()
    {
        Console.WriteLine("Loading data");
    }

    [AttributeUsage(AttributeTargets.Method)]
    class ImportantMethod : Attribute
    {
        public string Level { get; }

        public ImportantMethod()
        {
            Level = "HIGH";
        }

        public ImportantMethod(string level)
        {
            Level = level;
        }
    }
}
