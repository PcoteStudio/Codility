namespace Codility
{
    namespace PassingCars
    {
        public class PassingCars
        {
            public int Solution(int[] A)
            {
                long passingCars = 0;
                int[] westCounts = new int[A.Length + 1];

                for (int i = A.Length - 1; i >= 0; i--)
                    if (A[i] == 1)
                        westCounts[i] = 1 + westCounts[i + 1];
                    else
                        westCounts[i] = westCounts[i + 1];

                for (int i = 0; i < A.Length; i++)
                    if (A[i] == 0)
                        passingCars += westCounts[i + 1];

                if (passingCars > 1000000000)
                    return -1;
                return (int) passingCars;
            }
        }
    }
}
