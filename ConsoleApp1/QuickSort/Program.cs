using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorts
{
    public class Program
    {

        public int Partition(int[] arr, int low, int high)
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

        public void QuickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(arr, low, high);

                QuickSort(arr, low, pi - 1);
                QuickSort(arr, pi + 1, high);
            }
        }


        static void Main(string[] args)
        {
            Program pr = new Program();
            int[] arr = { 10, 7, 8, 9, 1, 5 };
            int n = arr.Length;
            Stopwatch t = Stopwatch.StartNew();
            pr.QuickSort(arr, 0, n - 1);
            Console.WriteLine(t.Elapsed.TotalMilliseconds);
            arr.ToList().ForEach(a => Console.WriteLine(a));



            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
