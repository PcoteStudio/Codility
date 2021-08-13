using System;

namespace Codility
{
    namespace MissingInteger
    {
        public class MissingInteger
        {
            public int Solution(int[] A)
            {
                Array.Sort(A);
                int lowestAvailable = 1;
                for (int i = 0; i < A.Length; i++)
                {
                    if (A[i] < 1)
                        continue;
                    if (lowestAvailable == A[i])
                        lowestAvailable++;
                    else if (lowestAvailable > A[i])
                        continue;
                    else
                        return lowestAvailable;
                }
                return lowestAvailable;
            }
        }
    }
}
