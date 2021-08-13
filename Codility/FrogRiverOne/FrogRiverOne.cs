using System.Collections.Generic;

namespace Codility
{
    namespace FrogRiverOne
    {
        public class FrogRiverOne
        {
            public int Solution(int X, int[] A)
            {
                if (X == 0)
                    return 0;
                HashSet<int> positions = new HashSet<int>();
                for (int i = 0; i < A.Length; i++)
                {
                    if (!positions.Contains(A[i]))
                        positions.Add(A[i]);
                    if (positions.Count == X)
                        return i;
                }
                return -1;
            }
        }
    }
}
