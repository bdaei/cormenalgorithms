using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CormenAlgorithms.Ch4DivideNConquer.Tests
{
    [TestClass]
    public class MaximumSubarrayTests
    {
        [TestMethod]
        public void Should_Find_Maximum_Profit()
        {
            int[] A = new int[] { 13, -3, -25, 20, -3, -16, -23, 18, 20, -7, 12, -5, -22, 15, -4, 7 };
            var sut = new MaximumSubarray();

            var max = sut.FindMaximumSubarray(A, 0, A.Length - 1);

            Assert.AreEqual(7, max.Item1);
            Assert.AreEqual(10, max.Item2);
            Assert.AreEqual(43, max.Item3);
        }

        /// <summary>
        /// Exercise 4.1-1: What does FIND-MAXIMUM-SUBARRAY return when all elements of A are negative?
        /// Answer: It returns the maximum value in the array.
        /// </summary>
        [TestMethod]
        public void Test_All_Negative_Values()
        {
            int[] A = new int[] { -10, -7, -5, -11, -3, -14 };
            var sut = new MaximumSubarray();

            var max = sut.FindMaximumSubarray(A, 0, A.Length - 1);

            Assert.AreEqual(4, max.Item1);
            Assert.AreEqual(4, max.Item2);
            Assert.AreEqual(-3, max.Item3);
        }


    }
}
