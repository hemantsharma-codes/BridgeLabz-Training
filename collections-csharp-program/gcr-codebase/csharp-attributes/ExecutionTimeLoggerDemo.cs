using System;
using System.Diagnostics;
using System.Reflection;

class ExecutionTimeLoggerDemo
{
    static void Main(string[] args)
    {
        MethodInfo[] methods = typeof(ExecutionTimeLoggerDemo).GetMethods(BindingFlags.Static | BindingFlags.NonPublic);

        foreach (MethodInfo method in methods)
        {
            object[] attributes = method.GetCustomAttributes(typeof(LogExecutionTime), false);
            if (attributes.Length > 0)
            {
                Stopwatch stopwatch = Stopwatch.StartNew();
                method.Invoke(null, null);
                stopwatch.Stop();
                Console.WriteLine(method.Name);
                Console.WriteLine(stopwatch.ElapsedMilliseconds);
            }
        }
    }

    [LogExecutionTime]
    static void FastMethod()
    {
        for (int i = 0; i < 100000; i++)
        {
        }
    }

    [LogExecutionTime]
    static void SlowMethod()
    {
        for (int i = 0; i < 5000000; i++)
        {
        }
    }

    [AttributeUsage(AttributeTargets.Method)]
    class LogExecutionTime : Attribute
    {
    }
}
