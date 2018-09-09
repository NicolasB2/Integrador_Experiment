using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sorts;


namespace UnitText

{
    [TestClass]
    public class SortingText
    {
        //Attributes
        private int[] arr;
        private Program pr;


        //SetUps
        public void SetUp1()
        {
            pr = new Program();
            arr = new int[]{ 10, 1324, 356, 0, 4785430, 1000000000, 1198, 7, 3210, 345435};
        }

        public void SetUp2()
        {
            pr = new Program();
            arr = new int[] { 0, 7, 356, 1198, 1324, 3210, 345435, 4875430, 1000000000 };
        }

        public void SetUp3()
        {
            pr = new Program();
            arr = new int[] { 1000000000, 4875430, 345435, 3210, 1324, 1198, 356, 7, 0};
        }

        public void SetUp4(int size)
        {
            pr = new Program();
            arr = GenerateArray.RandomArray(size);
        }

        public void SetUp5(int size)
        {
            SetUp4(size);
            arr = GenerateArray.OrderArray(size);
        }

        public void SetUp6(int size)
        {
            SetUp4(size);
            arr = new int[size];
            arr = GenerateArray.DescendingArray(size);
        }


        //Methodds
        public void QuickText()
        {
            int n = arr.Length;
            pr.QuickSort(arr, 0, n - 1);
            for (int i = 1; i < n; i++)
                Assert.IsTrue(arr[i - 1] < arr[i]);
        }

        public void RandomText()
        {
            int n = arr.Length;
            pr.RandomizedQuickSort(arr, 0, n - 1);
            for (int i = 1; i < n; i++)
                Assert.IsTrue(arr[i - 1] < arr[i]);
        }


        //QuickSort

        //Shrot input
        [TestMethod]
        public void Quick_Short_Disorder()
        {
            SetUp1();
            QuickText();
        }

        [TestMethod]
        public void Quick_Short_Oreder()
        {
            SetUp2();
            QuickText();
        }

        [TestMethod]
        public void Quick_Short_Descending()
        {
            SetUp3();
            QuickText();
        }

        //Long input
        [TestMethod]
        public void Quick_990_Disorder()
        {
            SetUp4(990);
            QuickText();
        }

        [TestMethod]
        public void Quick_990_Oreder()
        {
            SetUp5(990);
            QuickText();
        }

        [TestMethod]
        public void Quick_990_Descending()
        {
            SetUp6(990);
            QuickText();
        }


        ////RandomSort

        ////Shrot input
        [TestMethod]
        public void Random_Short_Disorder()
        {
            SetUp1();
            RandomText();
        }

        [TestMethod]
        public void Random_Short_Oreder()
        {
            SetUp2();
            RandomText();
        }

        [TestMethod]
        public void Random_Short_OrederDescending()
        {
            SetUp3();
            RandomText();
        }

        //Long input
        [TestMethod]
        public void Random_990_Disorder()
        {
            SetUp4(990);
            RandomText();
        }

        [TestMethod]
        public void Random_990_Oreder()
        {
            SetUp5(990);
            RandomText();
        }

        [TestMethod]
        public void Random_990_Descending()
        {
            SetUp6(990);
            RandomText();
        }

    }


}
