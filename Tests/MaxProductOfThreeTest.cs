using Codility.MaxProductOfThree;
using Xunit;

namespace Tests
{
    public class MaxProductOfThreeTest
    {
        MaxProductOfThree model = new MaxProductOfThree();

        public MaxProductOfThreeTest()
        {

        }

        [Fact]
        public void Test_NoPositiveFactors()
        {
            Assert.Equal(-6, model.Solution(new int[] {-1, -2, -3, -4, -5}));
        }

        [Fact]
        public void Test_OnePositiveFactor()
        {
            Assert.Equal(200, model.Solution(new int[] {10, -2, -3, -4, -5}));
        }

        [Fact]
        public void Test_TwoPositiveFactors()
        {
            Assert.Equal(200, model.Solution(new int[] {10, 9, -3, -4, -5}));
        }

        [Fact]
        public void Test_ThreePositiveFactors()
        {
            Assert.Equal(200, model.Solution(new int[] {10, 9, 2, -3, -4, -5}));
        }
    }
}