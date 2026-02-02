using System;
using System.IO;
using Newtonsoft.Json.Linq;

class MergeJsonFiles
{
    static void Main()
    {
        string file1 = "file1.json";
        string file2 = "file2.json";

        if (File.Exists(file1) && File.Exists(file2))
        {
            JObject obj1 = JObject.Parse(File.ReadAllText(file1));
            JObject obj2 = JObject.Parse(File.ReadAllText(file2));
            obj1.Merge(obj2);
            Console.WriteLine(obj1.ToString());
        }
        else
        {
            Console.WriteLine("One or both files not found");
        }
    }
}
