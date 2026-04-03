using System;
using System.Reflection;

class ReflectionDependencyInjectionDemo
{
    static void Main(string[] args)
    {
        ReflectionDependencyInjectionDemo container = new ReflectionDependencyInjectionDemo();
        Client client = new Client();
        container.InjectDependencies(client);
        client.Run();
    }

    void InjectDependencies(object target)
    {
        FieldInfo[] fields = target.GetType().GetFields(BindingFlags.Instance | BindingFlags.NonPublic);

        foreach (FieldInfo field in fields)
        {
            if (Attribute.IsDefined(field, typeof(Inject)))
            {
                object dependency = Activator.CreateInstance(field.FieldType);
                field.SetValue(target, dependency);
            }
        }
    }

    class Client
    {
        [Inject]
        private Service service;

        public void Run()
        {
            service.Execute();
        }
    }

    class Service
    {
        public void Execute()
        {
            Console.WriteLine("Service executed");
        }
    }

    [AttributeUsage(AttributeTargets.Field)]
    class Inject : Attribute
    {
    }
}
