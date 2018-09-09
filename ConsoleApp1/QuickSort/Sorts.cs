using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Sorts
    {

        //QuickSort**************************************************************************

        public void QuickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(arr, low, high);

                QuickSort(arr, low, pi - 1);
                QuickSort(arr, pi + 1, high);
            }
        }
        public static int Partition(int[] arr, int low, int high)
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


        //RandomizedQuickSort****************************************************************
        public void RandomizedQuickSort(int[] input, int left, int right)
        {
            if (left < right)
            {
                int q = RandomizedPartition(input, left, right);
                RandomizedQuickSort(input, left, q - 1);
                RandomizedQuickSort(input, q + 1, right);
            }
        }

        private static int RandomizedPartition(int[] input, int left, int right)
        {
            Random random = new Random();
            int i = random.Next(left, right);

            int pivot = input[i];
            input[i] = input[right];
            input[right] = pivot;

            return Partition(input, left, right);
        }

    }
}
