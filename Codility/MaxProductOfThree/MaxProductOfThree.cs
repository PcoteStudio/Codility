using System;
using System.Linq;

namespace Codility
{
    namespace MaxProductOfThree
    {
        public class MaxProductOfThree
        {
            public int Solution(int[] A)
            {
                Array.Sort(A);
                long r = A[A.Length - 1];
                long q = A[A.Length - 2];
                long p = A[A.Length - 3];
                long maxProduct = p * q * r;

                r = A[A.Length - 1];
                q = A[1];
                p = A[0];
                maxProduct = Math.Max(maxProduct, p * q * r);

                return (int)maxProduct;
            }
        }
    }
}
