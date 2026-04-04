using System;
using System.IO;
using Newtonsoft.Json.Linq;
class ReadJsonFileDemo
{
    static void Main()
    {
        string fileName = "data.json";
        if (File.Exists(fileName))
        {
            string content = File.ReadAllText(fileName);
            JObject obj = JObject.Parse(content);
            foreach (var property in obj.Properties())
            {
                Console.WriteLine(property.Name + ": " + property.Value);
            }
        }
        else
        {
            Console.WriteLine("File not found");
        }
    }
}
