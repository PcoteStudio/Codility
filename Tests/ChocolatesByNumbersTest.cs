using Codility.ChocolatesByNumbers;
using Xunit;

namespace Tests
{
    public class ChocolatesByNumbersTest
    {
        ChocolatesByNumbers model = new ChocolatesByNumbers();

        public ChocolatesByNumbersTest()
        {

        }

        [Fact]
        public void Test_MPair()
        {
            Assert.Equal(5, model.Solution(10, 4));
        }

        [Fact]
        public void Test_MPrime()
        {
            Assert.Equal(8, model.Solution(8, 3));
        }

        [Fact]
        public void Test_NPrime()
        {
            Assert.Equal(13, model.Solution(13, 6));
        }
    }
}