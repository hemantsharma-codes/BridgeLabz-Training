using System;
using System.Reflection;

class SimpleCalculator
{
    private int MultiplyNumbers(int firstNumber, int secondNumber)
    {
        return firstNumber * secondNumber;
    }
}

class PrivateMethodCallProgram
{
    static void Main(string[] args)
    {
        if (args.Length < 2)
        {
            Console.WriteLine("Please provide two numbers");
            return;
        }

        int numberOne = int.Parse(args[0]);
        int numberTwo = int.Parse(args[1]);

        SimpleCalculator calculatorObject = new SimpleCalculator();
        Type calculatorType = typeof(SimpleCalculator);

        MethodInfo multiplyMethod = calculatorType.GetMethod(
            "MultiplyNumbers",
            BindingFlags.NonPublic | BindingFlags.Instance
        );

        object result = multiplyMethod.Invoke(
            calculatorObject,
            new object[] { numberOne, numberTwo }
        );

        Console.WriteLine("Result: " + result);
    }
}

