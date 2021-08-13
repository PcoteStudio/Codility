using Codility.TapeEquilibrium;
using Xunit;

namespace Tests
{
    public class TapeEquilibriumTest
    {
        TapeEquilibrium model = new TapeEquilibrium();

        public TapeEquilibriumTest()
        {

        }

        [Fact]
        public void Test_TwoElements()
        {
            Assert.Equal(2000, model.Solution(new int[] {10, 2010}));
        }

        [Fact]
        public void Test_TwoElementsWithNeg()
        {
            Assert.Equal(2000, model.Solution(new int[] {-1000, 1000}));
        }

        [Fact]
        public void Test_FiveElementsWithNeg()
        {
            Assert.Equal(5, model.Solution(new int[] {10, -60, 20, -50, 75}));
        }
    }
}