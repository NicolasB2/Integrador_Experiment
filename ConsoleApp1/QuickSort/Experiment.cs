using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Experiment
    {
        public static void Document (List<double> time, int i)
        {
            try
            {
                StreamWriter sw = new StreamWriter("C:\\Users\\Asus\\Desktop\\DatosAnova" + i + ".txt", true);

                time.ToList().ForEach(n => sw.WriteLine(n));
                sw.WriteLine("****************");
                sw.Close();
            }
            catch (Exception z)
            {
                Console.WriteLine("Exception: " + z.Message);
            }

        }

        public static void Experiment_Quick(int i)
        {
            
            Sorts s = new Sorts();

            List<double> a = new List<double>();
            List<double> b = new List<double>();
            List<double> c = new List<double>();
            List<double> time = new List<double>();
            double size = Math.Pow(10, i);

            //Console.WriteLine("prueba con n = {0}", size);
            Console.WriteLine();
                
                for (int j = 0; j <= 1000; j++)
                {
                //arreglo original

                
                int[] arr = GenerateArray.OrderArray((int)size);

                TimeSpan start0 = new TimeSpan(DateTime.Now.Ticks);
                s.QuickSort(arr, 0, arr.Length - 1);
                TimeSpan stop0 = new TimeSpan(DateTime.Now.Ticks);
                a.Add(stop0.Subtract(start0).TotalMilliseconds);
                time.Add(stop0.Subtract(start0).TotalMilliseconds);


                int[] arr1 = GenerateArray.OrderArray(arr);
                TimeSpan start1 = new TimeSpan(DateTime.Now.Ticks);
                s.QuickSort(arr, 0, arr.Length - 1);
                TimeSpan stop1 = new TimeSpan(DateTime.Now.Ticks);
                b.Add(stop1.Subtract(start1).TotalMilliseconds);
                time.Add(stop1.Subtract(start1).TotalMilliseconds);

                int[] arr2 = GenerateArray.DescendingArray(arr1);
                TimeSpan start2 = new TimeSpan(DateTime.Now.Ticks);
                s.QuickSort(arr, 0, arr.Length - 1);
                TimeSpan stop2 = new TimeSpan(DateTime.Now.Ticks);
                c.Add(stop2.Subtract(start2).TotalMilliseconds);
                time.Add(stop2.Subtract(start2).TotalMilliseconds);
            }

            Console.WriteLine("entrada aleatorea: {0}", a.Average());
            Console.WriteLine();
            Console.WriteLine("entrada ordenada: {0}", b.Average());
            Console.WriteLine();
            Console.WriteLine("entrada descendente: {0}", c.Average());
            Console.WriteLine();

            Document(time, i);


        }

        public static void Experiment_Random(int i)
        {

            Sorts s = new Sorts();

            List<double> a = new List<double>();
            List<double> b = new List<double>();
            List<double> c = new List<double>();
            List<double> time = new List<double>();

            //Console.WriteLine("prueba con n = {0}", size);
            Console.WriteLine();
            double size = Math.Pow(10, i);
            

            for (int j = 0; j <= 1000; j++)
            {
                //arreglo original
                int[] arr = GenerateArray.OrderArray((int)size);

                TimeSpan start0 = new TimeSpan(DateTime.Now.Ticks);
                s.RandomizedQuickSort(arr, 0, arr.Length - 1);
                TimeSpan stop0 = new TimeSpan(DateTime.Now.Ticks);
                a.Add(stop0.Subtract(start0).TotalMilliseconds);
                time.Add(stop0.Subtract(start0).TotalMilliseconds);

                int[] arr1 = GenerateArray.OrderArray(arr);
                TimeSpan start1 = new TimeSpan(DateTime.Now.Ticks);
                s.RandomizedQuickSort(arr, 0, arr.Length - 1);
                TimeSpan stop1 = new TimeSpan(DateTime.Now.Ticks);
                b.Add(stop1.Subtract(start1).TotalMilliseconds);
                time.Add(stop0.Subtract(start0).TotalMilliseconds);

                int[] arr2 = GenerateArray.DescendingArray(arr1);
                TimeSpan start2 = new TimeSpan(DateTime.Now.Ticks);
                s.RandomizedQuickSort(arr, 0, arr.Length - 1);
                TimeSpan stop2 = new TimeSpan(DateTime.Now.Ticks);
                c.Add(stop2.Subtract(start2).TotalMilliseconds);
                time.Add(stop0.Subtract(start0).TotalMilliseconds);
            }

            Console.WriteLine("entrada aleatorea: {0}", a.Average());
            Console.WriteLine();
            Console.WriteLine("entrada ordenada: {0}", b.Average());
            Console.WriteLine();
            Console.WriteLine("entrada descendente: {0}", c.Average());
            Console.WriteLine();

            Document(time, i);
        }

        static void Main(string[] args)
        {
            for (int i =1; i<5;i++)
            {
                Experiment_Quick(i);
                Experiment_Random(i);
            }
           
            Console.ReadLine();
        }
    }
}
