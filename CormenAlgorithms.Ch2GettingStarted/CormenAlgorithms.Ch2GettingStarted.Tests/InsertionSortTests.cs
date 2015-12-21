using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CormenAlgorithms.Ch2GettingStarted.Tests
{
    [TestClass]
    public class InsertionSortTests
    {
        [TestMethod]
        public void ShouldSort()
        {
            var A = new int[] { 5, 2, 4, 6, 1, 3 };
            var sut = new InsertionSort();

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
