using System;
class ExamScoreSelectionSort
{
    static void Main()
    {
        int[] examScores = { 72, 88, 65, 91, 78 };

        SortExamScoresUsingSelectionSort(examScores);

        Console.WriteLine("Sorted Exam Scores (Ascending Order):");
        DisplayExamScores(examScores);
    }

    // Utility method that performs Selection Sort
    static void SortExamScoresUsingSelectionSort(int[] scores)
    {
        for (int startIndex = 0; startIndex < scores.Length - 1; startIndex++)
        {
            int minimumScoreIndex = startIndex;

            // Find the minimum score in the unsorted part
            for (int currentIndex = startIndex + 1; currentIndex < scores.Length; currentIndex++)
            {
                if (scores[currentIndex] < scores[minimumScoreIndex])
                {
                    minimumScoreIndex = currentIndex;
                }
            }

            // Swap minimum value with the first unsorted element
            if (minimumScoreIndex != startIndex)
            {
                SwapValues(scores, startIndex, minimumScoreIndex);
            }
        }
    }

    // Utility method to swap two values
    static void SwapValues(int[] data, int firstPosition, int secondPosition)
    {
        int temporaryValue = data[firstPosition];
        data[firstPosition] = data[secondPosition];
        data[secondPosition] = temporaryValue;
    }

    // Utility method to display exam scores
    static void DisplayExamScores(int[] scores)
    {
        foreach (int score in scores)
            Console.Write(score + " ");
    }
}

