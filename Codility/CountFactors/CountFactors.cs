using System;

namespace Codility
{
    namespace CountFactors
    {
        public class CountFactors
        {
            public int Solution(int N)
            {
                double sqrt = Math.Sqrt(N);
                int factorCount = sqrt % 1 == 0 ? 1 : 0;
                for (int i = 1; i < sqrt; i++)
                    if (N % i == 0)
                        factorCount += 2;
                return factorCount;
            }
        }
    }
}
