using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;


namespace UnitText

{
    [TestClass]
    public class SortingText
    {
        //Attributes
        private int[] arr;
        private Sorts pr;


        //SetUps
        public void SetUp1()
        {
            pr = new Sorts();
            arr = new int[]{ 10, 1324, 356, 0, 4785430, 1000000000, 1198, 7, 3210, 345435};
        }

        public void SetUp2()
        {
            pr = new Sorts();
            arr = new int[] { 0, 7, 356, 1198, 1324, 3210, 345435, 4875430, 1000000000 };
        }

        public void SetUp3()
        {
            pr = new Sorts();
            arr = new int[] { 1000000000, 4875430, 345435, 3210, 1324, 1198, 356, 7, 0};
        }

        public void SetUp4(int size)
        {
            pr = new Sorts();
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
                Assert.IsTrue(arr[i - 1] <= arr[i]);
        }

        public void RandomText()
        {
            int n = arr.Length;
            pr.RandomizedQuickSort(arr, 0, n - 1);
            for (int i = 1; i < n; i++)
                Assert.IsTrue(arr[i - 1] <= arr[i]);
        }


        //QuickSort********************************************************************

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

        [TestMethod]
        public void Quick_5298_Disorder()
        {
            SetUp4(5298);
            QuickText();
        }

        [TestMethod]
        public void Quick_5298_Oreder()
        {
            SetUp5(5298);
            QuickText();
        }

        [TestMethod]
        public void Quick_5298_Descending()
        {
            SetUp6(5298);
            QuickText();
        }

        [TestMethod]
        public void Quick_17634_Disorder()
        {
            SetUp4(17600);
            QuickText();
        }

        [TestMethod]
        public void Quick_17634_Oreder()
        {
            SetUp5(17634);
            QuickText();
        }

        [TestMethod]
        public void Quick_17634_Descending()
        {
            SetUp6(17634);
            QuickText();
        }

        //[TestMethod]
        //public void Quick_999999_Disorder()
        //{
        //    SetUp4(999990);
        //    QuickText();
        //}

        //[TestMethod]
        //public void Quick_999999_Oreder()
        //{
        //    SetUp5(999999);
        //    QuickText();
        //}

        //[TestMethod]
        //public void Quick_999999_Descending()
        //{
        //    SetUp6(999999);
        //    QuickText();
        //}

        [TestMethod]
        public void Quick_384759_Disorder()
        {
            SetUp4(384759);
            QuickText();
        }

        [TestMethod]
        public void Quick_384759_Oreder()
        {
            SetUp5(384759);
            QuickText();
        }

        [TestMethod]
        public void Quick_384759_Descending()
        {
            SetUp6(384759);
            QuickText();
        }
        


        //RandomSort****************************************************************************

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

        [TestMethod]
        public void Random_5298_Disorder()
        {
            SetUp4(5298);
            RandomText();
        }

        [TestMethod]
        public void Random_5298_Oreder()
        {
            SetUp5(5298);
            RandomText();
        }

        [TestMethod]
        public void Random_5298_Descending()
        {
            SetUp6(5298);
            RandomText();
        }

        [TestMethod]
        public void Random_17634_Disorder()
        {
            SetUp4(17634);
            RandomText();
        }

        [TestMethod]
        public void Random_17634_Oreder()
        {
            SetUp5(17634);
            RandomText();
        }

        [TestMethod]
        public void Random_17634_Descending()
        {
            SetUp6(17634);
            RandomText();
        }

        //[TestMethod]
        //public void Random_999999_Disorder()
        //{
        //    SetUp4(999999);
        //    RandomText();
        //}

        //[TestMethod]
        //public void Random_999999_Oreder()
        //{
        //    SetUp5(999999);
        //    RandomText();
        //}

        //[TestMethod]
        //public void Random_999999_Descending()
        //{
        //    SetUp6(999999);
        //    RandomText();
        //}

        [TestMethod]
        public void Random_384759_Disorder()
        {
            SetUp4(384759);
            RandomText();
        }

        [TestMethod]
        public void Random_384759_Oreder()
        {
            SetUp5(384759);
            RandomText();
        }

        [TestMethod]
        public void Random_384759_Descending()
        {
            SetUp6(384759);
            RandomText();
        }
    }


}
