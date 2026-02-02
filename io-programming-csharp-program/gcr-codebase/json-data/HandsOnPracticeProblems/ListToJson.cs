using System;
using System.Collections.Generic;
using Newtonsoft.Json;

class User
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class ListToJson
{
    static void Main()
    {
        List<User> users = new List<User>
        {
            new User { Name = "Alice", Age = 22 },
            new User { Name = "Bob", Age = 30 }
        };
        string json = JsonConvert.SerializeObject(users, Formatting.Indented);
        Console.WriteLine(json);
    }
}
