using System;

namespace Codility
{
    namespace MaxSliceSum
    {
        public class MaxSliceSum
        {
            public int Solution(int[] A)
            {
                int slice = 0;
                int ending = 0;
                int maxValue = int.MinValue;
                for (int i = 0; i < A.Length; i++)
                {
                    maxValue = Math.Max(maxValue, A[i]);
                    ending = Math.Max(0, ending + A[i]);
                    slice = Math.Max(slice, ending);
                }
                return (maxValue >= 0) ? slice : maxValue;
            }
        }
    }
}
