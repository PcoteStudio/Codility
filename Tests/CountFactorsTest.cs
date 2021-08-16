using Codility.CountFactors;
using Xunit;

namespace Tests
{
    public class CountFactorsTest
    {
        CountFactors model = new CountFactors();

        public CountFactorsTest()
        {

        }

        [Fact]
        public void Test_1()
        {
            Assert.Equal(1, model.Solution(1));
        }

        [Fact]
        public void Test_24()
        {
            Assert.Equal(8, model.Solution(24));
        }

        [Fact]
        public void Test_36()
        {
            Assert.Equal(9, model.Solution(36));
        }
    }
}