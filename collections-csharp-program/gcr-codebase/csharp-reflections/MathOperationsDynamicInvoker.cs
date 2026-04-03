using System;
using System.Reflection;

class MathOperationsDynamicInvoker
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter method name (Add / Subtract / Multiply)");
        string methodName = Console.ReadLine();

        Console.WriteLine("Enter first number");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter second number");
        int b = int.Parse(Console.ReadLine());

        MethodInfo method = typeof(MathOperationsDynamicInvoker).GetMethod(methodName, BindingFlags.Static | BindingFlags.Public);

        if (method != null)
        {
            object result = method.Invoke(null, new object[] { a, b });
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("Invalid method name");
        }
    }

    public static int Add(int x, int y)
    {
        return x + y;
    }

    public static int Subtract(int x, int y)
    {
        return x - y;
    }

    public static int Multiply(int x, int y)
    {
        return x * y;
    }
}
