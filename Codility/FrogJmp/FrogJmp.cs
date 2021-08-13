using System;

namespace Codility
{
    namespace FrogJmp
    {
        public class FrogJmp
        {
            public int Solution(int X, int Y, int D)
            {
                if(X >= Y) return 0;
                return (int) Math.Ceiling((Y - X) / (double) D);
            }
        }
    }
}
