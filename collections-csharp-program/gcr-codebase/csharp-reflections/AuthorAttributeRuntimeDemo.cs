using System;
using System.Reflection;

class AuthorAttributeRuntimeDemo
{
    static void Main(string[] args)
    {
        Type type = typeof(AuthorAttributeRuntimeDemo);
        object[] attributes = type.GetCustomAttributes(typeof(Author), false);

        foreach (Author author in attributes)
        {
            Console.WriteLine(author.Name);
        }
    }

    [Author("Hemant Sharma")]
    static void Display()
    {
    }

    [AttributeUsage(AttributeTargets.Class)]
    class Author : Attribute
    {
        public string Name { get; }

        public Author(string name)
        {
            Name = name;
        }
    }
}
