using System.Collections.Generic;

namespace Codility
{
    namespace StoneWall
    {
        public class StoneWall
        {
            public int Solution(int[] H)
            {
                int blockCount = 0;
                Stack<int> heights = new Stack<int>();
                for (int i = 0; i < H.Length; i++)
                {
                    while (heights.Count != 0 && heights.Peek() > H[i])
                        heights.Pop();
                    if (heights.Count == 0)
                    {
                        blockCount++;
                        heights.Push(H[i]);
                    }
                    if (heights.Peek() < H[i])
                    {
                        blockCount++;
                        heights.Push(H[i]);
                    }
                }
                return blockCount;
            }
        }
    }
}
