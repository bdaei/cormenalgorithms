using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CormenAlgorithms.Ch4DivideNConquer.Tests
{
    [TestClass]
    public class MaximumSubarrayNonrecursiveTests
    {
        [TestMethod]
        public void Should_Find_Maximum_Profit()
        {
            int[] A = new int[] { 13, -3, -25, 20, -3, -16, -23, 18, 20, -7, 12, -5, -22, 15, -4, 7 };
            var sut = new MaximumSubarrayNonrecursive();

            var max = sut.FindMaximumSubarray(A);

            Assert.AreEqual(7, max.Item1);
            Assert.AreEqual(10, max.Item2);
            Assert.AreEqual(43, max.Item3);
        }
    }
}
