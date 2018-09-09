using System;
using System.Diagnostics;
using System.Linq;

namespace Sorts
{
    class Program
    {
        public static int partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];

            int i = (low - 1);
            for (int j = low; j < high; j++)
            {

                if (arr[j] <= pivot)
                {
                    i++;

                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            // swap arr[i+1] and arr[high] (or pivot) 
            int temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;

            return i + 1;
        }

        public static void quickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pi = partition(arr, low, high);

                quickSort(arr, low, pi - 1);
                quickSort(arr, pi + 1, high);
            }
        }


        static void Main(string[] args)
        {
            int[] arr = { 10, 7, 8, 9, 1, 5 };
            int n = arr.Length;
            Stopwatch t = Stopwatch.StartNew();
            quickSort(arr, 0, n - 1);
            Console.WriteLine(t.Elapsed.TotalMilliseconds);
            arr.ToList().ForEach(a => Console.WriteLine(a));

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
