using System.Collections.Generic;
using System.Linq;

namespace Codility
{
    namespace OddOccurrencesInArray
    {
        public class OddOccurrencesInArray
        {
            public int Solution(int[] A)
            {
                Dictionary<int, int> counts = new Dictionary<int, int>();
                for (int i = 0; i < A.Length; i++)
                {
                    if (!counts.ContainsKey(A[i]))
                        counts.Add(A[i], 1);
                    else
                        counts[A[i]]++;
                }
                var pair = counts.FirstOrDefault(c => c.Value % 2 == 1);
                if (pair.Key > 0)
                    return pair.Key;
                return 0;
            }
        }
    }
}
