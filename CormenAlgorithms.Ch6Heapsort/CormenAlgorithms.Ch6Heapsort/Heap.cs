using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CormenAlgorithms.Ch6Heapsort
{
    public class Heap
    {
        public int[] Array { get; set; }
        public int HeapSize { get; set; }
        public Heap(int[] array)
        {
            this.Array = array;
        }
        public int Left(int i)
        {
            return (i << 1) + 1;
        }
        public int Right(int i)
        {
            return (i << 1) + 2;
        }
        public int Parent(int i)
        {
            return (i - 1) >> 1;
        }
    }
}
