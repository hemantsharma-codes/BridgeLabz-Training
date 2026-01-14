using System;
using System.Diagnostics;
class FibonacciPerformanceComparison
{
    // Recursive Fibonacci : O(2^N)
    static long RecursiveFibonacci(int termNumber)
    {
        if (termNumber <= 1)
        {
            return termNumber;
        }

        return RecursiveFibonacci(termNumber-1)+RecursiveFibonacci(termNumber-2);
    }

    // Iterative Fibonacci : O(N)
    static long IterativeFibonacci(int termNumber)
    {
        if (termNumber <= 1)
        {
            return termNumber;
        }

        long previousTerm = 0;
        long currentTerm = 1;

        for (int currentIndex=2;currentIndex<=termNumber;currentIndex++)
        {
            long nextTerm = previousTerm + currentTerm;
            previousTerm = currentTerm;
            currentTerm = nextTerm;
        }

        return currentTerm;
    }

    static void Main()
    {
        int fibonacciTerm = 40;

        Stopwatch stopwatch = new Stopwatch();

        // Recursive Fibonacci
        stopwatch.Start();
        long recursiveResult = RecursiveFibonacci(fibonacciTerm);
        stopwatch.Stop();

        Console.WriteLine("Recursive Fibonacci Result: " + recursiveResult);
        Console.WriteLine("Time Taken (ms): " + stopwatch.ElapsedMilliseconds);

        // Iterative Fibonacci
        stopwatch.Reset();
        stopwatch.Start();
        long iterativeResult = IterativeFibonacci(fibonacciTerm);
        stopwatch.Stop();

        Console.WriteLine("\nIterative Fibonacci Result: " + iterativeResult);
        Console.WriteLine("Time Taken (ms): " + stopwatch.ElapsedMilliseconds);
    }
}

