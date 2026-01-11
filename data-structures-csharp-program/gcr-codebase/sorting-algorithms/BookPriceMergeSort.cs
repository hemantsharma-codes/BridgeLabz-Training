using System;
class BookPriceMergeSort
{
    static void Main()
    {
        int[] bookPrices = { 450, 120, 300, 200, 150 };

        SortBookPricesUsingMergeSort(bookPrices);

        Console.WriteLine("Sorted Book Prices (Ascending Order):");
        DisplayBookPrices(bookPrices);
    }

    // Entry utility method for Merge Sort
    static void SortBookPricesUsingMergeSort(int[] prices)
    {
        if (prices == null || prices.Length <= 1)
            return;

        PerformMergeSort(prices, 0, prices.Length - 1);
    }

    // Recursive divide method
    static void PerformMergeSort(int[] prices, int leftIndex, int rightIndex)
    {
        if (leftIndex < rightIndex)
        {
            int middleIndex = leftIndex + (rightIndex - leftIndex) / 2;

            PerformMergeSort(prices, leftIndex, middleIndex);
            PerformMergeSort(prices, middleIndex + 1, rightIndex);

            MergeSortedHalves(prices, leftIndex, middleIndex, rightIndex);
        }
    }

    // Utility method to merge two sorted halves
    static void MergeSortedHalves(int[] prices, int leftIndex, int middleIndex, int rightIndex)
    {
        int leftSize = middleIndex - leftIndex + 1;
        int rightSize = rightIndex - middleIndex;

        int[] leftPrices = new int[leftSize];
        int[] rightPrices = new int[rightSize];

        for (int i = 0; i < leftSize; i++)
            leftPrices[i] = prices[leftIndex + i];

        for (int j = 0; j < rightSize; j++)
            rightPrices[j] = prices[middleIndex + 1 + j];

        int leftPointer = 0;
        int rightPointer = 0;
        int mergedIndex = leftIndex;

        while (leftPointer < leftSize && rightPointer < rightSize)
        {
            if (leftPrices[leftPointer] <= rightPrices[rightPointer])
                prices[mergedIndex++] = leftPrices[leftPointer++];
            else
                prices[mergedIndex++] = rightPrices[rightPointer++];
        }

        // Copy remaining elements
        while (leftPointer < leftSize)
            prices[mergedIndex++] = leftPrices[leftPointer++];

        while (rightPointer < rightSize)
            prices[mergedIndex++] = rightPrices[rightPointer++];
    }

    // Utility method to display prices
    static void DisplayBookPrices(int[] prices)
    {
        foreach (int price in prices)
            Console.Write(price + " ");
    }
}

