using System;

class InsertionSortAlgorithm
{
    public static void InsertionSort(int[] arr)
    {
        int n = arr.Length;

        for (int i = 1; i < n; i++)
        {
            int key = arr[i];
            int j = i - 1;

            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j--;
            }
            arr[j + 1] = key;
        }
    }

    public static void TestInsertionSort()
    {
        int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
        Console.WriteLine("Original Array for Insertion Sort: " + string.Join(", ", arr));

        InsertionSort(arr);

        Console.WriteLine("Sorted Array by Insertion Sort: " + string.Join(", ", arr));
    }
}
