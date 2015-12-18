using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CormenAlgorithms.Ch4DivideNConquer
{
    /// <summary>
    /// Chapter 4
    /// Section 4.1 The maximum subarray problem
    /// </summary>
    public class MaximumSubarray
    {
        private Tuple<int, int, int> FindMaxCrossing(int[] A, int low, int mid, int high)
        {
            int leftSum = int.MinValue;
            int sum = 0;
            int maxLeft = mid;
            for (int i = mid; i >= 0; --i)
            {
                sum += A[i];
                if (sum > leftSum)
                {
                    leftSum = sum;
                    maxLeft = i;
                }
            }

            int rightSum = int.MinValue;
            sum = 0;
            int maxRight = mid + 1;
            for (int j = mid + 1; j <= high; ++j)
            {
                sum += A[j];
                if(sum > rightSum)
                {
                    rightSum = sum;
                    maxRight = j;
                }
            }

            return new Tuple<int, int, int>(maxLeft, maxRight, leftSum + rightSum);
        }
        
        public Tuple<int, int, int> FindMaximumSubarray(int[] A, int low, int high)
        {
            if (low == high)
                return new Tuple<int, int, int>(low, high, A[low]);
            else
            {
                int mid = (low + high) / 2;
                var left = FindMaximumSubarray(A, low, mid);
                int leftLow = left.Item1,
                    leftHigh = left.Item2,
                    leftSum = left.Item3;
                    
                var cross = FindMaxCrossing(A, low, mid, high);
                int crossLow = cross.Item1,
                    crossHigh = cross.Item2,
                    crossSum = cross.Item3;

                var right = FindMaximumSubarray(A, mid + 1, high);
                int rightLow = right.Item1,
                    rightHigh = right.Item2,
                    rightSum = right.Item3;

                if (leftSum >= rightSum && leftSum >= crossSum)
                    return left;
                else if (rightSum >= leftSum && rightSum >= crossSum)
                    return right;
                else
                    return cross;
            }
        }
    }
}
