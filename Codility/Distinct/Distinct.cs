using System.Collections.Generic;

namespace Codility
{
    namespace Distinct
    {
        public class Distinct
        {
            public int Solution(int[] A)
            {
                HashSet<int> numbers = new HashSet<int>();
                for (int i = 0; i < A.Length; i++)
                    if (!numbers.Contains(A[i]))
                        numbers.Add(A[i]);
                return numbers.Count;
            }
        }
    }
}
