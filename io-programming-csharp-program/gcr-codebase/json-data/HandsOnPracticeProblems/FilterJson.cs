using System;
using Newtonsoft.Json.Linq;

class FilterJson
{
    static void Main()
    {
        string jsonData = @"
        [
            { 'name': 'Alice', 'age': 22 },
            { 'name': 'Bob', 'age': 30 },
            { 'name': 'Charlie', 'age': 28 }
        ]";

        JArray users = JArray.Parse(jsonData);
        foreach (var user in users)
        {
            if ((int)user["age"] > 25)
            {
                Console.WriteLine(user.ToString());
            }
        }
    }
}
