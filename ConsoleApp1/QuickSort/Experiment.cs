using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Experiment
    {
        static void Main(string[] args)
        {
            Sorts pr = new Sorts();

            int[] arr = { 10, 7, 8, 9, 1, 5 };
            int n = arr.Length;

            Stopwatch t = Stopwatch.StartNew();
            pr.QuickSort(arr, 0, n - 1);
            pr.RandomizedQuickSort(arr, 0, n - 1);

            Console.WriteLine(t.Elapsed.TotalMilliseconds);
            arr.ToList().ForEach(a => Console.WriteLine(a));

            Console.ReadLine();
        }
    }
}
