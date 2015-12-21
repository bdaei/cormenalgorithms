using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CormenAlgorithms.Ch2GettingStarted
{
    public class InsertionSort : ISort
    {
        public void Sort(int[] A)
        {
            for(int j = 1; j < A.Length; j++)
            {
                var key = A[j];
                var i = j - 1;
                while(i >= 0 && A[i] > key)
                {
                    A[i + 1] = A[i];
                    i--;
                }
                A[i + 1] = key;
            }
        }
    }
}
