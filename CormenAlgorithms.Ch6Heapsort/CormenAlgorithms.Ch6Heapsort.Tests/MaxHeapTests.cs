using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CormenAlgorithms.Ch6Heapsort.Tests
{
    [TestClass]
    public class MaxHeapTests
    {
        [TestMethod]
        public void MaxHeapify_should_maintain_maxheap()
        {
            var sut = new MaxHeap(new int[] { 16, 4, 10, 14, 7, 9, 3, 2, 8, 1 });
            sut.HeapSize = 10;

            sut.MaxHeapify(1);

            Assert.AreEqual(14, sut.Array[1]);
            Assert.AreEqual(8, sut.Array[3]);
            Assert.AreEqual(4, sut.Array[8]);
        }
        [TestMethod]
        public void MaxHeapifyNonRecursive_should_maintain_maxheap()
        {
            var sut = new MaxHeap(new int[] { 16, 4, 10, 14, 7, 9, 3, 2, 8, 1 });
            sut.HeapSize = 10;

            sut.MaxHeapifyNonRecursive(1);

            Assert.AreEqual(14, sut.Array[1]);
            Assert.AreEqual(8, sut.Array[3]);
            Assert.AreEqual(4, sut.Array[8]);
        }
        [TestMethod]
        public void BuildMaxHeap_should_create_a_maxheap()
        {
            var array = new int[100];
            for (int i = 0; i < 100; i++)
                array[i] = i + 1;
            var sut = new MaxHeap(array);

            sut.BuildMaxHeap();

            Assert.AreEqual(100, sut.HeapSize);
            for (int i = 0; i < 49; i++)
            { 
                Assert.IsTrue(sut.Array[i] > sut.Array[sut.Left(i)]);
                Assert.IsTrue(sut.Array[i] > sut.Array[sut.Right(i)]);
            }
        }

    }
}
