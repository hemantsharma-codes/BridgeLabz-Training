using System;
using System.Diagnostics;
using System.Text;
class StringConcatenationPerformance
{
    static void Main(string[] args)
    {
        int totalIterations = 1000000;
        string baseText = "A";

        Stopwatch stopwatch = new Stopwatch();

        // String Concatenation
        string stringResult = "";

        stopwatch.Start();
        for (int i = 0; i < totalIterations; i++)
        {
            stringResult = stringResult + baseText;
        }
        stopwatch.Stop();

        Console.WriteLine("String Concatenation:");
        Console.WriteLine("Time Taken (ms): " + stopwatch.ElapsedMilliseconds);

        // StringBuilder Concatenation
        StringBuilder stringBuilder = new StringBuilder();

        stopwatch.Reset();
        stopwatch.Start();
        for (int i = 0; i < totalIterations; i++)
        {
            stringBuilder.Append(baseText);
        }
        stopwatch.Stop();

        Console.WriteLine("\nStringBuilder Concatenation:");
        Console.WriteLine("Time Taken (ms): " + stopwatch.ElapsedMilliseconds);
    }
}

