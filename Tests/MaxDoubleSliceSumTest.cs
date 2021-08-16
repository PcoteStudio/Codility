using Codility.MaxDoubleSliceSum;
using Xunit;

namespace Tests
{
    public class MaxDoubleSliceSumTest
    {
        MaxDoubleSliceSum model = new MaxDoubleSliceSum();

        public MaxDoubleSliceSumTest()
        {

        }

        [Fact]
        public void Test_PositiveAndNegative()
        {
            Assert.Equal(17, model.Solution(new int[] { 3, 2, 6, -1, 4, 5, -1, 2 }));
        }

        [Fact]
        public void Test_NegativeOnly()
        {
            Assert.Equal(0, model.Solution(new int[] { -5, -2, -1, -3, -1, -2, -7 }));
        }
    }
}