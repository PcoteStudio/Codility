namespace Codility
{
    namespace PermCheck
    {
        public class PermCheck
        {
            public int Solution(int[] A)
            {
                bool[] counters = new bool[A.Length];
                for (int i = 0; i < A.Length; i++)
                {
                    if (A[i] > A.Length || counters[A[i] - 1])
                        return 0;
                    counters[A[i] - 1] = true;
                }
                return 1;
            }
        }
    }
}
