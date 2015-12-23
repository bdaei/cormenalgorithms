using CormenAlgorithms.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CormenAlgorithms.Ch6Heapsort
{
    public class Heapsort : ISort
    {
        public void Sort(int[] A)
        {
            var maxHeap = new MaxHeap(A);
            maxHeap.BuildMaxHeap();
            for(int i = A.Length - 1; i >= 1; --i)
            {
                var temp = A[i];
                A[i] = A[0];
                A[0] = temp;
                maxHeap.HeapSize = maxHeap.HeapSize - 1;
                maxHeap.MaxHeapify(0);
            }
        }
    }
}
