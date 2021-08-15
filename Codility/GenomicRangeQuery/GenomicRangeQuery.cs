namespace Codility
{
    namespace GenomicRangeQuery
    {
        public class GenomicRangeQuery
        {
            public int[] Solution(string S, int[] P, int[] Q)
            {
                int[] impacts = new int[P.Length];

                int[] aCount = new int[S.Length + 1];
                int[] cCount = new int[S.Length + 1];
                int[] gCount = new int[S.Length + 1];
                int[] tCount = new int[S.Length + 1];

                int currentACount = 0;
                int currentCCount = 0;
                int currentGCount = 0;
                int currentTCount = 0;

                for (int i = 0; i < S.Length; i++)
                {
                    switch (S[i])
                    {
                        case 'A':
                            currentACount++;
                            break;
                        case 'C':
                            currentCCount++;
                            break;
                        case 'G':
                            currentGCount++;
                            break;
                        case 'T':
                            currentTCount++;
                            break;
                    }
                    aCount[i + 1] = currentACount;
                    cCount[i + 1] = currentCCount;
                    gCount[i + 1] = currentGCount;
                    tCount[i + 1] = currentTCount;
                }

                for (int i = 0; i < P.Length; i++)
                {
                    if (Q[i] == P[i])
                        switch (S[P[i]])
                        {
                            case 'A':
                                impacts[i] = 1;
                                break;
                            case 'C':
                                impacts[i] = 2;
                                break;
                            case 'G':
                                impacts[i] = 3;
                                break;
                            case 'T':
                                impacts[i] = 4;
                                break;
                        }
                    else if (aCount[Q[i]+1] - aCount[P[i]] > 0)
                        impacts[i] = 1;
                    else if (cCount[Q[i]+1] - cCount[P[i]] > 0)
                        impacts[i] = 2;
                    else if (gCount[Q[i]+1] - gCount[P[i]] > 0)
                        impacts[i] = 3;
                    else if (tCount[Q[i]+1] - tCount[P[i]] > 0)
                        impacts[i] = 4;
                }

                return impacts;
            }
        }
    }
}
