using System;
using System.Collections.Generic;

namespace Codility
{
    namespace CountNonDivisible
    {
        public class CountNonDivisible
        {
            public int[] Solution(int[] A)
            {
                int[] results = new int[A.Length];
                Dictionary<int, int> instanceCounts = new Dictionary<int, int>();
                Dictionary<int, int> nonDivisorCounts = new Dictionary<int, int>();

                for (int i = 0; i < A.Length; i++)
                {
                    if (!instanceCounts.ContainsKey(A[i]))
                        instanceCounts.Add(A[i], 1);
                    else
                        instanceCounts[A[i]]++;
                }

                foreach (int n in instanceCounts.Keys)
                {
                    int divisorCount = 0;
                    double sqrt = Math.Sqrt(n);
                    for (int i = 1; i <= sqrt; i++)
                        if (n % i == 0)
                        {
                            if (instanceCounts.ContainsKey(i))
                                divisorCount += instanceCounts[i];
                            if (i != sqrt && instanceCounts.ContainsKey(n / i))
                                divisorCount += instanceCounts[n / i];
                        }
                    nonDivisorCounts.Add(n, A.Length - divisorCount);
                }

                for (int i = 0; i < A.Length; i++)
                    results[i] = nonDivisorCounts[A[i]];

                return results;
            }
        }
    }
}
