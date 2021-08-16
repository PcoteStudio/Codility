using Codility.CountNonDivisible;
using Xunit;

namespace Tests
{
    public class CountNonDivisibleTest
    {
        CountNonDivisible model = new CountNonDivisible();

        public CountNonDivisibleTest()
        {

        }

        [Fact]
        public void Test_Example()
        {
            Assert.Equal(new int[] { 2, 4, 3, 2, 0 }, model.Solution(new int[] { 3, 1, 2, 3, 6 }));
        }
    }
}