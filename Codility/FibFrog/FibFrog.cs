using System;
using System.Collections.Generic;

namespace Codility
{
    namespace FibFrog
    {
        public class FibFrog
        {
            public int Solution(int[] A)
            {
                // F(27) is longer than the max river size
                List<int> fibonacciMemo = new List<int>(27);
                fibonacciMemo.Add(0);
                fibonacciMemo.Add(1);
                while (true)
                {
                    int f = fibonacciMemo[fibonacciMemo.Count - 2] + fibonacciMemo[fibonacciMemo.Count - 1];
                    if (f > A.Length + 1)
                        break;
                    fibonacciMemo.Add(f);
                }
                fibonacciMemo.Reverse();
                fibonacciMemo.Remove(0);

                List<KeyValuePair<int,int>> paths = new List<KeyValuePair<int,int>>();
                paths.Add(new KeyValuePair<int, int>(-1, 0)); // Position, #Jumps
                int i = 0;
                while (true)
                {
                    if (i >= paths.Count)
                        return -1;

                    KeyValuePair<int,int> currentPath = paths[i];
                    foreach (int jump in fibonacciMemo)
                    {
                        int newPos = currentPath.Key + jump;
                        if (newPos == A.Length)
                            return currentPath.Value + 1;
                        if (newPos > A.Length || A[newPos] == 0)
                            continue;
                        paths.Add(new KeyValuePair<int, int>(newPos, currentPath.Value + 1));
                        A[newPos] = 0;
                    }
                    i++;
                }
            }
        }
    }
}
