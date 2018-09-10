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

        public static void Experiment_Quick(int size)
        {
            
            Sorts s = new Sorts();

            List<double> a = new List<double>();
            List<double> b = new List<double>();
            List<double> c = new List<double>();


            //Console.WriteLine("prueba con n = {0}", size);
            Console.WriteLine();

                for (int j = 0; j <= 1000; j++)
                {
                //arreglo original
                int[] arr = GenerateArray.OrderArray(size);

                TimeSpan start0 = new TimeSpan(DateTime.Now.Ticks);
                s.QuickSort(arr, 0, arr.Length - 1);
                TimeSpan stop0 = new TimeSpan(DateTime.Now.Ticks);
                a.Add(stop0.Subtract(start0).TotalMilliseconds);


                int[] arr1 = GenerateArray.OrderArray(arr);
                TimeSpan start1 = new TimeSpan(DateTime.Now.Ticks);
                s.QuickSort(arr, 0, arr.Length - 1);
                TimeSpan stop1 = new TimeSpan(DateTime.Now.Ticks);
                b.Add(stop1.Subtract(start1).TotalMilliseconds);

                int[] arr2 = GenerateArray.DescendingArray(arr1);
                TimeSpan start2 = new TimeSpan(DateTime.Now.Ticks);
                s.QuickSort(arr, 0, arr.Length - 1);
                TimeSpan stop2 = new TimeSpan(DateTime.Now.Ticks);
                c.Add(stop2.Subtract(start2).TotalMilliseconds);
            }

            Console.WriteLine("entrada aleatorea: {0}", a.Average());
            Console.WriteLine();
            Console.WriteLine("entrada ordenada: {0}", b.Average());
            Console.WriteLine();
            Console.WriteLine("entrada descendente: {0}", c.Average());
            Console.WriteLine();
        }

        public static void Experiment_Random(int size)
        {

            Sorts s = new Sorts();

            List<double> a = new List<double>();
            List<double> b = new List<double>();
            List<double> c = new List<double>();


            //Console.WriteLine("prueba con n = {0}", size);
            Console.WriteLine();

            for (int j = 0; j <= 1000; j++)
            {
                //arreglo original
                int[] arr = GenerateArray.OrderArray(size);

                TimeSpan start0 = new TimeSpan(DateTime.Now.Ticks);
                s.RandomizedQuickSort(arr, 0, arr.Length - 1);
                TimeSpan stop0 = new TimeSpan(DateTime.Now.Ticks);
                a.Add(stop0.Subtract(start0).TotalMilliseconds);


                int[] arr1 = GenerateArray.OrderArray(arr);
                TimeSpan start1 = new TimeSpan(DateTime.Now.Ticks);
                s.RandomizedQuickSort(arr, 0, arr.Length - 1);
                TimeSpan stop1 = new TimeSpan(DateTime.Now.Ticks);
                b.Add(stop1.Subtract(start1).TotalMilliseconds);

                int[] arr2 = GenerateArray.DescendingArray(arr1);
                TimeSpan start2 = new TimeSpan(DateTime.Now.Ticks);
                s.RandomizedQuickSort(arr, 0, arr.Length - 1);
                TimeSpan stop2 = new TimeSpan(DateTime.Now.Ticks);
                c.Add(stop2.Subtract(start2).TotalMilliseconds);
            }

            Console.WriteLine("entrada aleatorea: {0}", a.Average());
            Console.WriteLine();
            Console.WriteLine("entrada ordenada: {0}", b.Average());
            Console.WriteLine();
            Console.WriteLine("entrada descendente: {0}", c.Average());
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Experiment_Quick(100000);
            Experiment_Random(100000);
            Console.ReadLine();

        }
    }
}
