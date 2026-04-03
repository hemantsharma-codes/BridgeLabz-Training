using System;
using System.Diagnostics;
class SortingAlgoComparison
{
    // Bubble Sort : O(N^2)
    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;

        for (int i=0;i<n-1;i++)
        {
            for (int j=0;j<n-i-1;j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }

    // Merge Sort : O(N log N)
    static void MergeSort(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int mid = left+(right-left)/2;

            MergeSort(arr,left,mid);
            MergeSort(arr,mid+1,right);

            Merge(arr,left,mid,right);
        }
    }

    static void Merge(int[] arr, int left, int mid, int right)
    {
        int n1 = mid - left + 1;
        int n2 = right - mid;

        int[] L = new int[n1];
        int[] R = new int[n2];

        for(int i=0;i<n1;i++)
        {
            L[i] = arr[left + i];
        }

        for(int j=0;j<n2;j++)
        {
            R[j] = arr[mid + 1 + j];
        }

        int iIndex = 0;
        int jIndex = 0;
        int k = left;

        while (iIndex<n1 && jIndex<n2)
        {
            if (L[iIndex] <= R[jIndex])
            {
                arr[k] = L[iIndex];
                iIndex++;
            }
            else
            {
                arr[k] = R[jIndex];
                jIndex++;
            }
            k++;
        }

        while (iIndex < n1)
        {
            arr[k] = L[iIndex];
            iIndex++;
            k++;
        }

        while (jIndex < n2)
        {
            arr[k] = R[jIndex];
            jIndex++;
            k++;
        }
    }

    // Quick Sort : O(N log N)
    static void QuickSort(int[] arr, int low, int high)
    {
        if (low < high)
        {
            int pivotIndex = Partition(arr, low, high);

            QuickSort(arr, low, pivotIndex - 1);
            QuickSort(arr, pivotIndex + 1, high);
        }
    }

    static int Partition(int[] arr, int low, int high)
    {
        int pivot = arr[high];
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (arr[j] < pivot)
            {
                i++;

                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }

        int swap = arr[i + 1];
        arr[i + 1] = arr[high];
        arr[high] = swap;

        return i + 1;
    }

    static void Main()
    {
        int size = 20000; // Bubble sort is slow for very large sizes
        int[] originalData = new int[size];

        Random rnd = new Random();

        for (int i=0;i<size;i++)
        {
            originalData[i] = rnd.Next(1,size);
        }

        Stopwatch sw = new Stopwatch();

        // Bubble Sort
        int[] bubbleData = (int[])originalData.Clone();
        sw.Start();
        BubbleSort(bubbleData);
        sw.Stop();
        Console.WriteLine("Bubble Sort Time (ms): "+sw.ElapsedMilliseconds);

        // Merge Sort
        int[] mergeData = (int[])originalData.Clone();
        sw.Reset();
        sw.Start();
        MergeSort(mergeData,0,mergeData.Length-1);
        sw.Stop();
        Console.WriteLine("Merge Sort Time (ms): "+sw.ElapsedMilliseconds);

        // Quick Sort
        int[] quickData = (int[])originalData.Clone();
        sw.Reset();
        sw.Start();
        QuickSort(quickData,0,quickData.Length-1);
        sw.Stop();
        Console.WriteLine("Quick Sort Time (ms): "+sw.ElapsedMilliseconds);
    }
}

