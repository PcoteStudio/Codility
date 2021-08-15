namespace Codility
{
    namespace CountDiv
    {
        public class CountDiv
        {
            public int Solution(int A, int B, int K)
            {
                int modA = A % K;
                int minValid;
                if(A == 0)
                    minValid = K;
                else
                    minValid = A + K - (modA == 0 ? K : modA);
                if (minValid > B)
                    return 0;
                return (B - minValid) / K + 1;
            }
        }
    }
}
