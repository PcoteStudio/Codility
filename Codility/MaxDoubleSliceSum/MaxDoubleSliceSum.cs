using System;

namespace Codility
{
    namespace MaxDoubleSliceSum
    {
        public class MaxDoubleSliceSum
        {
            public int Solution(int[] A)
            {
                int[] maxLeft = new int[A.Length];
                for (int i = 1; i < A.Length; i++)
                    maxLeft[i] = Math.Max(0, maxLeft[i - 1] + A[i]);

                int[] maxRight = new int[A.Length];
                for (int i = A.Length - 2; i >= 0; i--)
                    maxRight[i] = Math.Max(0, maxRight[i + 1] + A[i]);

                int maxSum = 0;
                for (int i = 1; i < A.Length - 1; i++)
                    maxSum = Math.Max(maxSum, maxLeft[i - 1] + maxRight[i + 1]);
                
                return maxSum;
            }
        }
    }
}
