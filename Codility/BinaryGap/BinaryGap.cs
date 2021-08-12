using System;

namespace Codility
{
    namespace BinaryGap
    {
        public class BinaryGap
        {
            public int Solution(int N)
            {
                bool foundTrue = false;
                int longestGap = 0;
                int currentGap = 0;

                while (N != 0)
                {
                    if (!foundTrue)
                    {
                        if ((N & 1) == 1)
                            foundTrue = true;
                    }
                    else
                    {
                        if ((N & 1) == 1)
                        {
                            longestGap = Math.Max(longestGap, currentGap);
                            currentGap = 0;
                        }
                        else
                            currentGap++;
                    }
                    N = N >> 1;
                }
                return longestGap;
            }
        }
    }
}
