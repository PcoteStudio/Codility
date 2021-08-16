using System;
using System.Collections.Generic;

namespace Codility
{
    namespace Flags
    {
        public class Flags
        {
            public int Solution(int[] A)
            {
                // Find the peaks
                List<int> peaks = new List<int>();
                for (var i = 1; i < A.Length - 1; i++)
                    if (A[i] > A[i - 1] && A[i] > A[i + 1])
                        peaks.Add(i);

                // K=0 or K=1
                if (peaks.Count < 2)
                    return peaks.Count;

                // Find the max amount of flags for this configuration
                int maxFlags = (int)Math.Sqrt(peaks[peaks.Count - 1] - peaks[0]) + 1;
                for (int k = maxFlags; k > 0; k--)
                {
                    int flags = 1;
                    int lastFlag = 0;
                    for (int j = 1; j < peaks.Count; j++)
                    {
                        if (peaks[j] - peaks[lastFlag] >= k)
                        {
                            flags++;
                            lastFlag = j;
                        }
                        if (flags == k)
                            return flags;
                    }
                }
                return 0;
            }
        }
    }
}
