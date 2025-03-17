using System;

class Program
{
    static int BinarySearch(int[] arr, int target)
    {
        int left = 0, right = arr.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (arr[mid] == target)
                return mid; 

            if (arr[mid] < target)
                left = mid + 1; 
            else
                right = mid - 1; 
        }

        return -1; 
    }

    static void RunTestCases()
    {
        int[] sortedArray = { 2, 4, 7, 10, 15, 20, 25, 30 };

        // **Test Case 1: Best Case (O(1)) - Target found at the middle**
        int target1 = 10;
        int result1 = BinarySearch(sortedArray, target1);
        Console.WriteLine(result1 != -1
            ? $"Best Case: Found {target1} at index {result1}"
            : $"Best Case: {target1} not found");

        // **Test Case 2: Average Case (O(log N)) - Target found after a few comparisons**
        int target2 = 25;
        int result2 = BinarySearch(sortedArray, target2);
        Console.WriteLine(result2 != -1
            ? $"Average Case: Found {target2} at index {result2}"
            : $"Average Case: {target2} not found");

        // **Test Case 3: Worst Case (O(log N)) - Target not found**
        int target3 = 5;
        int result3 = BinarySearch(sortedArray, target3);
        Console.WriteLine(result3 != -1
            ? $"Worst Case: Found {target3} at index {result3}"
            : $"Worst Case: {target3} not found");
    }

    static void Main()
    {
        RunTestCases();
    }
}
