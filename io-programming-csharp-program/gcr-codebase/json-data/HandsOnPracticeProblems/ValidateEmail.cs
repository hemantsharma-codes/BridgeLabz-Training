using System;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;

class ValidateEmail
{
    static void Main()
    {
        string schemaJson = @"
        {
            'type': 'object',
            'properties': {
                'name': {'type':'string'},
                'email': {'type':'string','format':'email'}
            },
            'required': ['name','email']
        }";

        string jsonData = @"{ 'name':'Alice', 'email':'alice@example.com' }";

        JObject obj = JObject.Parse(jsonData);
        JSchema schema = JSchema.Parse(schemaJson);
        bool valid = obj.IsValid(schema);
        Console.WriteLine("Email validation result: " + valid);
    }
}
