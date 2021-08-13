namespace Codility
{
    namespace MaxCounters
    {
        public class MaxCounters
        {
            public int[] Solution(int N, int[] A)
            {
                int max = 0;
                int min = 0;
                int[] counters = new int[N];
                for (int i = 0; i < A.Length; i++)
                {
                    if (A[i] <= N)
                    {
                        int counterIndex = A[i] - 1;
                        if (counters[counterIndex] < min)
                            counters[counterIndex] = min;
                        counters[counterIndex]++;
                        if (counters[counterIndex] > max)
                            max = counters[counterIndex];
                    }
                    else if (A[i] == N + 1)
                    {
                        min = max;
                    }
                }
                for (int i = 0; i < N; i++)
                {
                    if (counters[i] < min)
                        counters[i] = min;
                }
                return counters;
            }
        }
    }
}
