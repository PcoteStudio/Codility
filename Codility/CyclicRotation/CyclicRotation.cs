namespace Codility
{
    namespace CyclicRotation
    {
        public class CyclicRotation
        {
            public int[] Solution(int[] A, int K)
            {
                if (K == 0)
                    return A;
                int[] newA = new int[A.Length];
                for (int i = 0; i < A.Length; i++)
                    newA[(i + K) % A.Length] = A[i];
                return newA;
            }
        }
    }
}
