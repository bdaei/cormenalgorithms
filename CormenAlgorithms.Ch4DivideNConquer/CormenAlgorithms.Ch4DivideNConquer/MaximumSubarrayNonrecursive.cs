using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CormenAlgorithms.Ch4DivideNConquer
{
    /// <summary>
    /// Exercise 4.1-5: a nonrecursive, linear-time algorithm for the maximum-subarray problem.
    /// </summary>
    public class MaximumSubarrayNonrecursive
    {
        public Tuple<int, int, int> FindMaximumSubarray(int[] A)
        {
            int maxToJ = 0;
            int max = 0;
            int h = 0;
            int l = 0;
            int i = 0;
            int j = 0;

            for (j = 0; j < A.Length - 1; j++)
            {
                maxToJ += A[j];
                if (A[j] > maxToJ)
                { 
                    i = j;
                    maxToJ = A[j];
                }
                if(maxToJ > max)
                {
                    max = maxToJ;
                    l = i;
                    h = j;
                }
            }
            return new Tuple<int, int, int>(l, h, max);
        }
    }
}
