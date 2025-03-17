using System;
using System.Diagnostics;

int LinearSearch(int[] arr, int target)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == target)
        {
            return i; 
        }
    }
    return -1; 
}

int[] arr2 = { 10, 20, 30, 40, 50 };
int target2 = 30;
Console.WriteLine(LinearSearch(arr2, target2)); // Average Case (Element in the Middle)

int[] arr1 = { 5, 10, 15, 20, 25 };
int target1 = 5;
Console.WriteLine(LinearSearch(arr1, target1)); // Best Case (Element at the First Index)

int[] arr3 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int target3 = 10;
Console.WriteLine(LinearSearch(arr3, target3)); // Worst Case (Element at the Last Index)


