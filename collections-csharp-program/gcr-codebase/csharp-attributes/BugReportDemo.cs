using System;
using System.Reflection;

class BugReportDemo
{
    static void Main(string[] args)
    {
        MethodInfo method = typeof(BugReportDemo).GetMethod("ExecuteTask");
        object[] attributes = method.GetCustomAttributes(typeof(BugReport), false);

        foreach (BugReport report in attributes)
        {
            Console.WriteLine(report.Description);
        }
    }

    [BugReport("Null reference occurs when input is empty")]
    [BugReport("Performance issue for large data set")]
    static void ExecuteTask()
    {
        Console.WriteLine("Task executed");
    }

    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    class BugReport : Attribute
    {
        public string Description { get; }

        public BugReport(string description)
        {
            Description = description;
        }
    }
}
