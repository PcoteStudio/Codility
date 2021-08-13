using System;

namespace Codility
{
    namespace TapeEquilibrium
    {
        public class TapeEquilibrium
        {
            public int Solution(int[] A)
            {
                long sum = 0;
                for (int i = 0; i < A.Length; i++)
                    sum += A[i];
                long minDiff = Int64.MaxValue;
                long leftSum = 0;
                long rightSum = sum;
                for (int p = 1; p < A.Length; p++)
                {
                    leftSum += A[p - 1];
                    rightSum -= A[p - 1];
                    minDiff = Math.Min(minDiff, Math.Abs(leftSum - rightSum));
                }
                return (int)minDiff;
            }
        }
    }
}
