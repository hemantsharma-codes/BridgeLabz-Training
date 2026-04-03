using System;
class ProductPriceQuickSort
{
    static void Main()
    {
        int[] productPrices = { 999, 499, 1299, 799, 299 };

        SortProductPricesUsingQuickSort(productPrices);

        Console.WriteLine("Sorted Product Prices (Ascending Order):");
        DisplayProductPrices(productPrices);
    }

    // Entry utility method for Quick Sort
    static void SortProductPricesUsingQuickSort(int[] prices)
    {
        if (prices == null || prices.Length <= 1)
            return;

        ApplyQuickSort(prices, 0, prices.Length - 1);
    }

    // Recursive Quick Sort method
    static void ApplyQuickSort(int[] prices, int startIndex, int endIndex)
    {
        if (startIndex < endIndex)
        {
            int pivotPosition = PartitionArray(prices, startIndex, endIndex);

            ApplyQuickSort(prices, startIndex, pivotPosition - 1);
            ApplyQuickSort(prices, pivotPosition + 1, endIndex);
        }
    }

    // Utility method to partition array using last element as pivot
    static int PartitionArray(int[] prices, int startIndex, int endIndex)
    {
        int pivotValue = prices[endIndex];
        int smallerElementIndex = startIndex - 1;

        for (int currentIndex = startIndex; currentIndex < endIndex; currentIndex++)
        {
            if (prices[currentIndex] < pivotValue)
            {
                smallerElementIndex++;
                SwapValues(prices, smallerElementIndex, currentIndex);
            }
        }

        SwapValues(prices, smallerElementIndex + 1, endIndex);
        return smallerElementIndex + 1;
    }

    // Utility method for swapping values
    static void SwapValues(int[] data, int firstIndex, int secondIndex)
    {
        int temporaryValue = data[firstIndex];
        data[firstIndex] = data[secondIndex];
        data[secondIndex] = temporaryValue;
    }

    // Utility method to display product prices
    static void DisplayProductPrices(int[] prices)
    {
        foreach (int price in prices)
            Console.Write(price + " ");
    }
}

