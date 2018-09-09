using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sorts;


namespace QuickSortText

{
    [TestClass]
    public class QuickSortText
    {

        [TestMethod]
        public void TestMethod1()
        {
            Program pr = new Program();
            int[] arr = { 10, 7, 8, 9, 1, 5 };
            int n = arr.Length;
            pr.QuickSort(arr, 0, n - 1);
            int[] answ = { 1, 5, 7, 8, 9, 10 };
            arr.ToList().ForEach(a => Console.WriteLine(a));

            Assert.AreEqual(arr[0], answ[0]);
        }
    }
}
