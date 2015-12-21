using System;
using CormenAlgorithms.Common;

namespace CormenAlgorithms.Ch4DivideNConquer
{
    public class MergeSort : ISort
    {
        public void Sort(int[] A)
        {
            Merge_Sort(A, 0, A.Length - 1);
        }

        private void Merge_Sort(int[] A, int p, int r)
        {
            if(p < r)
            {
                int q = (p + r) / 2;
                Merge_Sort(A, p, q);
                Merge_Sort(A, q + 1, r);
                Merge(A, p, q, r);
            }
        }

        private void Merge(int[] A, int p, int q, int r)
        {
            var merged = new int[r - p + 1];
            int i, j, k;
            for(i = p, j = q + 1, k = 0; i <= q && j <= r; k++)
                merged[k] = A[i] <= A[j] ? A[i++] : A[j++];
            while (i <= q)
                merged[k++] = A[i++];
            while (j <= r)
                merged[k++] = A[j++];
            for (i = p, k = 0; i <= r; i++, k++)
                A[i] = merged[k];
        }
    }
}
