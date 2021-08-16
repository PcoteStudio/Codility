namespace Codility
{
    namespace Dominator
    {
        public class Dominator
        {
            public int Solution(int[] A)
            {
                long size = 0;
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
                    return -1;

                int candidate = value;
                size = 0;
                for (int i = 0; i < A.Length; i++)
                    if (A[i] == candidate)
                    {
                        value = i;
                        size++;
                    }

                if (size > A.Length / 2.0)
                    return value;
                return -1;
            }
        }
    }
}
