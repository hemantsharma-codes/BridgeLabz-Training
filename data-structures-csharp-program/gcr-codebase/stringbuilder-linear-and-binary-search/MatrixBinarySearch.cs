using System;
class MatrixBinarySearch
{
    static bool BinarySearchRow(int[] row, int target)
    {
        int left = 0;
        int right = row.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (row[mid] == target)
            {
                return true;
            }
            else if (row[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return false;
    }

    static bool SearchInMatrix(int[,] matrix, int rows, int cols, int target)
    {
        for (int i = 0; i < rows; i++)
        {
            // check if target can exist in this row
            if (target >= matrix[i, 0] && target <= matrix[i, cols - 1])
            {
                int[] tempRow = new int[cols];

                for (int j = 0; j < cols; j++)
                {
                    tempRow[j] = matrix[i, j];
                }

                if (BinarySearchRow(tempRow, target))
                {
                    return true;
                }
            }
        }

        return false;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter number of rows:");
        int rows = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter number of columns:");
        int cols = int.Parse(Console.ReadLine());

        int[,] matrix = new int[rows, cols];

        Console.WriteLine("Enter matrix elements (row-wise):");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("Enter target value:");
        int target = int.Parse(Console.ReadLine());

        bool found = SearchInMatrix(matrix, rows, cols, target);

        if (found)
        {
            Console.WriteLine("Target value found in the matrix.");
        }
        else
        {
            Console.WriteLine("Target value not found in the matrix.");
        }
    }
}

