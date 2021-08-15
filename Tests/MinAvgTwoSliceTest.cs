using Codility.MinAvgTwoSlice;
using Xunit;

namespace Tests
{
    public class MinAvgTwoSliceTest
    {
        MinAvgTwoSlice model = new MinAvgTwoSlice();

        public MinAvgTwoSliceTest()
        {

        }

        [Fact]
        public void Test_OnlyPositives()
        {
            Assert.Equal(1, model.Solution(new int[] { 4, 2, 2, 5, 1, 5, 8 }));
        }

        [Fact]
        public void Test_WithNegatives()
        {
            Assert.Equal(5, model.Solution(new int[] { 10, 10, -1, 2, 4, -1, 2, -1 }));
        }
    }
}