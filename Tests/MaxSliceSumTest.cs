using Codility.MaxSliceSum;
using Xunit;

namespace Tests
{
    public class MaxSliceSumTest
    {
        MaxSliceSum model = new MaxSliceSum();

        public MaxSliceSumTest()
        {

        }

        [Fact]
        public void Test_WithANegative()
        {
            Assert.Equal(5, model.Solution(new int[] { 3, 2, -6, 4, 0 }));
        }

        [Fact]
        public void Test_WithAZero()
        {
            Assert.Equal(9, model.Solution(new int[] { 3, 2, 0, 4 }));
        }

        [Fact]
        public void Test_WithOnlyPositives()
        {
            Assert.Equal(14, model.Solution(new int[] { 3, 2, 5, 4 }));
        }

        [Fact]
        public void Test_WithOneValue()
        {
            Assert.Equal(3, model.Solution(new int[] { 3 }));
        }

        [Fact]
        public void Test_WithOnlyOneNegativeValue()
        {
            Assert.Equal(-3, model.Solution(new int[] { -3 }));
        }
    }
}