using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sorts;


namespace QuickSortText

{
    [TestClass]
    public class QuickSortText
    {
        private int[] arr;
        private int[] answ;
        private Program pr;

        public void SetUp1()
        {
            pr = new Program();
            arr = new int[]{ 54, 6, 90, 2, 27, 21, 4, 1};
            answ = new int[]{ 1, 2, 4, 6, 21, 27, 54, 90};
        }

        public void SetUp2()
        {
            pr = new Program();
            arr = new int[] { 1, 2, 4, 6, 21, 27, 54 ,90 };
            answ = arr;

        }

        public void SetUp3()
        {
            pr = new Program();
            arr = new int[] { 1, 7, 8, 9, 1, 5 };
            answ = new int[] { 1, 5, 7, 8, 9, 10 };
        }

        public void SetUp4()
        {
            pr = new Program();
            arr = new int[] { 54, 6, 90, 2, 27, 21, 4, 1 };
            answ = new int[] { 1, 2, 4, 6, 21, 27, 54, 90 };
        }

        public void SetUp5()
        {
            pr = new Program();
            arr = new int[] { 1, 2, 4, 6, 21, 27, 54, 90 };
            answ = arr;

        }

        public void SetUp6()
        {
            pr = new Program();
            arr = new int[] { 1, 7, 8, 9, 1, 5 };
            answ = new int[] { 1, 7, 8, 9, 1, 5 };
        }


        [TestMethod]
        public void Quick_Short_Disorder()
        {
            SetUp1();
            int n = arr.Length;
            pr.QuickSort(arr, 0, n - 1);
            for(int i = 0; i<n;i++)
            Assert.AreEqual(arr[i], answ[i]);
        }

        [TestMethod]
        public void Quick_Short_Oreder()
        {
            SetUp2();
            int n = arr.Length;
            pr.QuickSort(arr, 0, n - 1);
            for (int i = 0; i < n; i++)
                Assert.AreEqual(arr[i], answ[i]);
        }

        public void Quick_Short_OrederDescending()
        {
            SetUp3();
            int n = arr.Length;
            pr.QuickSort(arr, 0, n - 1);
            for (int i = 0; i < n; i++)
                Assert.AreEqual(arr[i], answ[i]);
        }

        [TestMethod]
        public void Quick_Long_Disorder()
        {
            SetUp1();
            int n = arr.Length;
            pr.QuickSort(arr, 0, n - 1);
            for (int i = 0; i < n; i++)
                Assert.AreEqual(arr[i], answ[i]);
        }

        [TestMethod]
        public void Quick_Long_Oreder()
        {
            SetUp2();
            int n = arr.Length;
            pr.QuickSort(arr, 0, n - 1);
            for (int i = 0; i < n; i++)
                Assert.AreEqual(arr[i], answ[i]);
        }

        [TestMethod]
        public void Quick_Long_OrederDescending()
        {
            SetUp3();
            int n = arr.Length;
            pr.QuickSort(arr, 0, n - 1);
            for (int i = 0; i < n; i++)
                Assert.AreEqual(arr[i], answ[i]);
        }

    }


}
