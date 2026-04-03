using System;
using System.Reflection;
using System.Text;

class JsonReflectionDemo
{
    static void Main(string[] args)
    {
        SampleData data = new SampleData(101, "Hemant", 21);
        string json = ConvertToJson(data);
        Console.WriteLine(json);
    }

    static string ConvertToJson(object obj)
    {
        Type type = obj.GetType();
        FieldInfo[] fields = type.GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
        StringBuilder builder = new StringBuilder();

        builder.Append("{");

        for (int i = 0; i < fields.Length; i++)
        {
            FieldInfo field = fields[i];
            builder.Append("\"");
            builder.Append(field.Name);
            builder.Append("\":");

            object value = field.GetValue(obj);

            if (value is string)
            {
                builder.Append("\"");
                builder.Append(value);
                builder.Append("\"");
            }
            else
            {
                builder.Append(value);
            }

            if (i < fields.Length - 1)
            {
                builder.Append(",");
            }
        }

        builder.Append("}");
        return builder.ToString();
    }

    class SampleData
    {
        private int Id;
        private string Name;
        private int Age;

        public SampleData(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }
    }
}
