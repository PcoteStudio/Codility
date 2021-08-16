namespace Codility
{
    namespace EquiLeader
    {
        public class EquiLeader
        {
            public int Solution(int[] A)
            {
                int size = 0;
                int value = -1;
                for (int i = 0; i < A.Length; i++)
                {
                    if (size == 0)
                    {
                        size++;
                        value = A[i];
                    }
                    else
                        size += (value == A[i]) ? 1 : -1;
                }

                if (size <= 0)
                    return 0;

                size = 0;
                int leader = value;
                int[] leaderCounts = new int[A.Length + 1];

                for (int i = 0; i < A.Length; i++)
                    if (A[i] == leader)
                        leaderCounts[i + 1] = leaderCounts[i] + 1;
                    else
                        leaderCounts[i + 1] = leaderCounts[i];

                if (leaderCounts[A.Length] <= A.Length / 2.0)
                    return 0;

                int equiCount = 0;
                for (int i = 0; i < A.Length; i++)
                {
                    if (leaderCounts[i + 1] > (i + 1) / 2.0
                    && leaderCounts[A.Length] - leaderCounts[i + 1] > (A.Length - i - 1) / 2.0)
                        equiCount++;
                }
                return equiCount;
            }
        }
    }
}
