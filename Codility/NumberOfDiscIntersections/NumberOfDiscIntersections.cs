using System;

namespace Codility
{
    namespace NumberOfDiscIntersections
    {
        public class NumberOfDiscIntersections
        {
            public int Solution(int[] A)
            {
                long intersectionCount = (long)A.Length * (A.Length - 1) / 2; // Maximum possible
                long[] left = new long[A.Length];
                long[] right = new long[A.Length];
                for (int i = 0; i < A.Length; i++)
                {
                    left[i] = (long)i - A[i];
                    right[i] = (long)i + A[i];
                }
                Array.Sort(left);
                Array.Sort(right);

                int j = 0;
                for (int i = 0; i < A.Length; i++)  // For every right side
                {
                    for (; j < A.Length; j++)   // From the current left side
                        if (left[j] > right[i]) // If a lack of intersection is reached
                        {
                            intersectionCount -= A.Length - j;  // Decrement by the number of unintersected disks
                            break;
                        }
                    if (j == A.Length)
                        break;
                }

                if (intersectionCount > 10E6)
                    return -1;
                return (int)intersectionCount;
            }
        }
    }
}
