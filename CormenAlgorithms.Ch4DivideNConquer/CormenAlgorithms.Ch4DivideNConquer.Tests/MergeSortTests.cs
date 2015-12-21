using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CormenAlgorithms.Ch4DivideNConquer.Tests
{
    [TestClass]
    public class MergeSortTests
    {
        [TestMethod]
        public void Should_Sort()
        {
            var A = new int[] { 6, 2, 4, 1, 3, 5 };
            var sut = new MergeSort();

            sut.Sort(A);

            Assert.AreEqual(1, A[0]);
            Assert.AreEqual(2, A[1]);
            Assert.AreEqual(3, A[2]);
            Assert.AreEqual(4, A[3]);
            Assert.AreEqual(5, A[4]);
            Assert.AreEqual(6, A[5]);
        }
    }
}
