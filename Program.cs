using System;

class Recursion
{
    static int minIndex(int[] a, int i, int j)
    {
        if (i == j)
            return i;

        int k = minIndex(a, i + 1, j);

        if (a[i] < a[k])
        {
            return i;
        }
        else
        {
            return k;
        }
    }

    static void recurSelectionSort(int[] a, int n, int index)
    {
        if (index == n)
            return;

        int k = minIndex(a, index, n - 1);

        if (k != index)
        {
            int temp = a[k];
            a[k] = a[index];
            a[index] = temp;
        }

        recurSelectionSort(a, n, index + 1);
    }

    static void PrintArray(int[] a)
    {
        for (int i = 0; i < a.Length; i++)
        {
            Console.Write(a[i] + " ");
        }
        Console.Write("\n");  
    }

    public static void Main(string[] args)
    {
        int[] arr = { 3, 1, 5, 2, 7, 0 };

        Console.Write("Array before sorting:\n"); 
        PrintArray(arr);

        recurSelectionSort(arr, arr.Length, 0);

        Console.Write("Array after sorting:\n"); 
        PrintArray(arr);
    }
}
