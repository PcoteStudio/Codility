using System;

namespace Codility
{
    namespace MaxProfit
    {
        public class MaxProfit
        {
            public int Solution(int[] A)
            {
                int[] maxSellingPrice = new int[A.Length + 1];
                for (int i = A.Length - 1; i > 0; i--)
                    maxSellingPrice[i - 1] = Math.Max(maxSellingPrice[i], A[i]);

                int maxProfit = 0;
                for (int i = 0; i < A.Length; i++)
                    maxProfit = Math.Max(maxSellingPrice[i] - A[i], maxProfit);

                return maxProfit;
            }
        }
    }
}
