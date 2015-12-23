using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CormenAlgorithms.Ch6Heapsort.Tests
{
    [TestClass]
    public class HeapTests
    {
        [TestMethod]
        public void Left_Should_Multiply_i_by_2()
        {
            var sut = new Heap(new int[] { });

            Assert.AreEqual(1, sut.Left(0));
            Assert.AreEqual(3, sut.Left(1));
        }
        [TestMethod]
        public void Right_Should_Multiply_i_by_2_and_add_1()
        {
            var sut = new Heap(new int[] { });

            Assert.AreEqual(2, sut.Right(0));
            Assert.AreEqual(6, sut.Right(2));
        }
        [TestMethod]
        public void Parent_should_divide_i_by_2()
        {
            var sut = new Heap(new int[] { });

            Assert.AreEqual(0, sut.Parent(1));
            Assert.AreEqual(1, sut.Parent(4));
        }
    }
}
