using System;

namespace Codility
{
    namespace Triangle
    {
        public class Triangle
        {
            public int Solution(int[] A)
            {
                Array.Sort(A);
                for (int i = 0; i < A.Length - 2; i++)
                    if ((long)A[i] + A[i + 1] > A[i + 2])
                        return 1;
                return 0;
            }
        }
    }
}
