using System;
using System.Reflection;

class TaskManagerDemo
{
    static void Main(string[] args)
    {
        MethodInfo method = typeof(TaskManagerDemo).GetMethod("ProcessTask");
        object[] attributes = method.GetCustomAttributes(false);

        foreach (object attr in attributes)
        {
            TaskInfo info = attr as TaskInfo;
            if (info != null)
            {
                Console.WriteLine(info.Priority);
                Console.WriteLine(info.AssignedTo);
            }
        }
    }

    [TaskInfo("High", "Hemant")]
    public static void ProcessTask()
    {
        Console.WriteLine("Task is running");
    }

    [AttributeUsage(AttributeTargets.Method)]
    class TaskInfo : Attribute
    {
        public string Priority { get; }
        public string AssignedTo { get; }

        public TaskInfo(string priority, string assignedTo)
        {
            Priority = priority;
            AssignedTo = assignedTo;
        }
    }
}
