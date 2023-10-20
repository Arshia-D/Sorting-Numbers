using System;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 3, 33, 20, 2, 0, -16, 55 };
        Console.WriteLine("Before sorting: ");
        PrintArray(arr);
        QuickSort(arr, 0, arr.Length - 1);
        Console.WriteLine("After sorting: ");
        PrintArray(arr);
    }

    static void QuickSort(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int pivotIndex = Partition(arr, left, right);
            QuickSort(arr, left, pivotIndex - 1);
            QuickSort(arr, pivotIndex + 1, right);
        }
    }

    static int Partition(int[] arr, int left, int right)
    {
        int pivot = arr[left];
        int fromLeft = left;
        int fromRight = right;
        while (true)
        {
            while (arr[fromLeft] < pivot)
            {
                fromLeft++;
            }
            while (arr[fromRight] > pivot)
            {
                fromRight--;
            }
            if (fromLeft < fromRight)
            {
                Swap(arr, fromLeft, fromRight);
            }
            else
            {
                return fromRight;
            }
        }
    }

    static void Swap(int[] arr, int index1, int index2)
    {
        int temp = arr[index1];
        arr[index1] = arr[index2];
        arr[index2] = temp;
    }

    static void PrintArray(int[] arr)
    {
        foreach (int i in arr)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
}
