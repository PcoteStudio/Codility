using System;

namespace Codility
{
    namespace MinAvgTwoSlice
    {
        public class MinAvgTwoSlice
        {
            public int Solution(int[] A)
            {
                decimal minAvg = decimal.MaxValue;
                int minAvgIndex = 0;
                for (int i = 0; i < A.Length - 1; i++)
                {
                    int sum = A[i] + A[i + 1];
                    decimal avg2 = sum / (decimal)2;
                    decimal avg3 = decimal.MaxValue;
                    if (i + 2 < A.Length)
                        avg3 = (sum + A[i + 2]) / (decimal)3;
                    decimal sliceAvg = Math.Min(avg2, avg3);

                    if (sliceAvg < minAvg)
                    {
                        minAvg = sliceAvg;
                        minAvgIndex = i;
                    }
                }
                return minAvgIndex;
            }
        }
    }
}
