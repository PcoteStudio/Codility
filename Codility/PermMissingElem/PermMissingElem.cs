namespace Codility
{
    namespace PermMissingElem
    {
        public class PermMissingElem
        {
            public int Solution(int[] A)
            {
                long sum = ((long)(A.Length + 1) * (A.Length + 2)) / 2;
                for (int i = 0; i < A.Length; i++)
                    sum -= A[i];
                return (int) sum;
            }
        }
    }
}
