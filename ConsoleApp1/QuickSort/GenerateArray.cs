using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorts
{
    public static class GenerateArray
    {
        public static int[] RandomArray(int size)
        {
            int[] arr = new int[size];
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = (int)rnd.Next(1, (int)Math.Pow(10, 9));
            }
            return arr;
        }

        public static int[] OrderArray(int size)
        {
            int [] arr = RandomArray(size);
            Array.Sort(arr);
            return arr;
        }

        public static int[] DescendingArray(int size)
        {
            int[] arr = RandomArray(size);
            arr.Reverse();
            return arr;
        }

    }
}
