using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CormenAlgorithms.Ch6Heapsort.Tests
{
    [TestClass]
    public class HeapsortTests
    {
        [TestMethod]
        public void Heapsort_should_sort()
        {
            var A = new int[] { 5, 7, 3, 2, 4, 8, 9, 1, 10, 6 };
            var sut = new Heapsort();

            sut.Sort(A);

            for (int i = 0; i < A.Length; i++)
                Assert.AreEqual(i + 1, A[i]);
        }
    }
}
