using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
class JsonHandlingDemo
{
    static void Main(string[] args)
    {
        BasicJsonObject();
        ConvertCarToJson();
        ReadJsonFileAndExtractFields();
        MergeJsonObjects();
        ValidateJsonStructure();
        ConvertListToJsonArray();
        FilterJsonByAge();
    }

    static void BasicJsonObject()
    {
        var student = new
        {
            name = "Alice",
            age = 22,
            subjects = new string[] { "Math", "Physics", "Chemistry" }
        };
        string json = JsonConvert.SerializeObject(student, Formatting.Indented);
        Console.WriteLine("Student JSON:");
        Console.WriteLine(json);
        Console.WriteLine();
    }

    static void ConvertCarToJson()
    {
        Car car = new Car { Brand = "Toyota", Model = "Corolla", Year = 2020 };
        string json = JsonConvert.SerializeObject(car, Formatting.Indented);
        Console.WriteLine("Car JSON:");
        Console.WriteLine(json);
        Console.WriteLine();
    }

    static void ReadJsonFileAndExtractFields()
    {
        string jsonFile = "sample.json";
        if (File.Exists(jsonFile))
        {
            string jsonContent = File.ReadAllText(jsonFile);
            JArray jsonArray = JArray.Parse(jsonContent);
            foreach (var item in jsonArray)
            {
                string name = item["name"]?.ToString();
                string email = item["email"]?.ToString();
                Console.WriteLine($"Name: {name}, Email: {email}");
            }
            Console.WriteLine();
        }
    }

    static void MergeJsonObjects()
    {
        JObject obj1 = JObject.Parse(@"{ 'name': 'Alice', 'age': 22 }");
        JObject obj2 = JObject.Parse(@"{ 'email': 'alice@example.com', 'city': 'Delhi' }");
        obj1.Merge(obj2);
        Console.WriteLine("Merged JSON:");
        Console.WriteLine(obj1.ToString());
        Console.WriteLine();
    }

    static void ValidateJsonStructure()
    {
        string schemaJson = @"
        {
            'type': 'object',
            'properties': {
                'name': {'type': 'string'},
                'age': {'type': 'integer'}
            },
            'required': ['name', 'age']
        }";

        string jsonData = @"{ 'name': 'Bob', 'age': 30 }";
        JSchema schema = JSchema.Parse(schemaJson);
        JObject obj = JObject.Parse(jsonData);
        bool valid = obj.IsValid(schema);
        Console.WriteLine("JSON is valid: " + valid);
        Console.WriteLine();
    }

    static void ConvertListToJsonArray()
    {
        List<Car> cars = new List<Car>
        {
            new Car{ Brand = "Honda", Model = "Civic", Year = 2019 },
            new Car{ Brand = "Ford", Model = "Focus", Year = 2018 }
        };
        string json = JsonConvert.SerializeObject(cars, Formatting.Indented);
        Console.WriteLine("Cars JSON Array:");
        Console.WriteLine(json);
        Console.WriteLine();
    }

    static void FilterJsonByAge()
    {
        string jsonData = @"
        [
            { 'name': 'Alice', 'age': 22 },
            { 'name': 'Bob', 'age': 28 },
            { 'name': 'Charlie', 'age': 26 }
        ]";
        JArray jsonArray = JArray.Parse(jsonData);
        var filtered = new JArray();
        foreach (var item in jsonArray)
        {
            if ((int)item["age"] > 25)
            {
                filtered.Add(item);
            }
        }
        Console.WriteLine("Filtered JSON (age > 25):");
        Console.WriteLine(filtered.ToString());
        Console.WriteLine();
    }
}

class Car
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
}
