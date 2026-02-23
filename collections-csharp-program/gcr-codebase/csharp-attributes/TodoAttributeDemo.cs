using System;
using System.Reflection;

class TodoAttributeDemo
{
    static void Main(string[] args)
    {
        MethodInfo[] methods = typeof(TodoAttributeDemo).GetMethods(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);

        foreach (MethodInfo method in methods)
        {
            object[] attributes = method.GetCustomAttributes(typeof(Todo), false);
            foreach (Todo todo in attributes)
            {
                Console.WriteLine(method.Name);
                Console.WriteLine(todo.Task);
                Console.WriteLine(todo.AssignedTo);
                Console.WriteLine(todo.Priority);
            }
        }
    }

    [Todo("Implement login feature", "Hemant")]
    static void Login()
    {
    }

    [Todo("Optimize database queries", "Amit", "HIGH")]
    static void OptimizeDatabase()
    {
    }

    [AttributeUsage(AttributeTargets.Method)]
    class Todo : Attribute
    {
        public string Task { get; }
        public string AssignedTo { get; }
        public string Priority { get; }

        public Todo(string task, string assignedTo)
        {
            Task = task;
            AssignedTo = assignedTo;
            Priority = "MEDIUM";
        }

        public Todo(string task, string assignedTo, string priority)
        {
            Task = task;
            AssignedTo = assignedTo;
            Priority = priority;
        }
    }
}
