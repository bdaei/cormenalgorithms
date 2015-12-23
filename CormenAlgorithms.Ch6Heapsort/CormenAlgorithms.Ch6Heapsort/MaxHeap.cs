using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CormenAlgorithms.Ch6Heapsort
{
    public class MaxHeap : Heap
    {
        public MaxHeap(int[] array) : base(array)
        { }
        public void MaxHeapify(int i)
        {
            int l = Left(i);
            int r = Right(i);
            int largest;

            if (l < HeapSize && Array[l] > Array[i])
                largest = l;
            else
                largest = i;
            if (r < HeapSize && Array[r] > Array[largest])
                largest = r;
            if (largest != i)
            {
                var temp = Array[i];
                Array[i] = Array[largest];
                Array[largest] = temp;
                MaxHeapify(largest);
            }
        }
        public void MaxHeapifyNonRecursive(int i)
        {
            int current = i;
            while (true)
            {
                int l = Left(current);
                int r = Right(current);
                int largest;

                if (l < HeapSize && Array[l] > Array[i])
                    largest = l;
                else
                    largest = current;
                if (r < HeapSize && Array[r] > Array[largest])
                    largest = r;
                if (largest != current)
                {
                    var temp = Array[current];
                    Array[current] = Array[largest];
                    Array[largest] = temp;
                    current = largest;
                }
                else
                    break;
            }
        }
        public void BuildMaxHeap()
        {
            HeapSize = Array.Length;
            for (int i = Array.Length / 2; i >= 0; --i)
                MaxHeapify(i);
        }
    }
}
