namespace Codility
{
    namespace ChocolatesByNumbers
    {
        public class ChocolatesByNumbers
        {
            public int Solution(int N, int M)
            {
                int gcd = Gcd(N, M, 1);
                return N / gcd;
            }

            public int Gcd(int a, int b, int res)
            {
                if (a == b)
                    return res * a;
                else if (a % 2 == 0 && b % 2 == 0)
                    return Gcd(a / 2, b / 2, 2 * res);
                else if (a % 2 == 0)
                    return Gcd(a / 2, b, res);
                else if (b % 2 == 0)
                    return Gcd(a, b / 2, res);
                else if (a > b)
                    return Gcd(a - b, b, res);
                else
                    return Gcd(a, b - a, res);
            }
        }
    }
}
