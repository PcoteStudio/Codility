using System.Collections.Generic;
using System.Linq;

namespace Codility
{
    namespace CountSemiPrime
    {
        public class CountSemiPrime
        {
            public int[] Solution(int N, int[] P, int[] Q)
            {
                long[] semiPrimes = GetSemiPrimeNumbers(N);
                long[] primeSumCounts = new long[N + 1];
                int lastSemiPrimeUsed = -1;
                for (int i = 3; i < primeSumCounts.Length; i++)
                {
                    if (lastSemiPrimeUsed + 1 < semiPrimes.Length && semiPrimes[lastSemiPrimeUsed + 1] == i)
                    {
                        lastSemiPrimeUsed++;
                        primeSumCounts[i] = primeSumCounts[i - 1] + 1;
                    }
                    else
                        primeSumCounts[i] = primeSumCounts[i - 1];
                }
                int[] results = new int[P.Length];
                for (int i = 0; i < P.Length; i++)
                    results[i] = (int)(primeSumCounts[Q[i]] - primeSumCounts[P[i] - 1]);
                return results;
            }

            public long[] GetSemiPrimeNumbers(int N)
            {
                bool[] primes = GetPrimeNumbers(N);
                SortedSet<long> semiPrimes = new SortedSet<long>();
                for (int i = 0; i < primes.Length; i++)
                {
                    if (primes[i] == false)
                        continue;
                    for (int j = i; j < primes.Length; j++)
                    {
                        if (primes[j] == false)
                            continue;
                        long sp = (long)i * j;
                        if (sp > N)
                            break;
                        semiPrimes.Add(sp);
                    }
                }
                return semiPrimes.ToArray();
            }

            public bool[] GetPrimeNumbers(int N)
            {
                bool[] sieve = new bool[N + 1];
                for (int x = 0; x < sieve.Length; x++)
                    sieve[x] = true;
                sieve[0] = false;
                sieve[1] = false;

                int i = 2;
                while (i * i <= N)
                {
                    if (sieve[i])
                    {
                        int k = i * i;
                        while (k <= N)
                        {
                            sieve[k] = false;
                            k += i;
                        }
                    }
                    i++;
                }
                return sieve;
            }

            public int[] GetFactorizationArray(int N)
            {
                int[] F = new int[N + 1];
                int i = 2;
                while (i * i <= N)
                {
                    if (F[i] == 0)
                    {
                        int k = i * i;
                        while (k <= N)
                        {
                            if (F[k] == 0)
                                F[k] = i;
                            k += i;
                        }
                    }
                    i++;
                }
                return F;
            }
        }
    }
}
