using Codility.CountSemiPrime;
using Xunit;

namespace Tests
{
    public class CountSemiPrimeTest
    {
        CountSemiPrime model = new CountSemiPrime();

        public CountSemiPrimeTest()
        {

        }

        [Fact]
        public void Test_Example()
        {
            Assert.Equal(new int[] { 10, 4, 0 }, model.Solution(26, new int[] { 1, 4, 16 }, new int[] { 26, 10, 20 }));
        }
    }
}