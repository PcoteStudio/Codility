using Codility.CyclicRotation;
using Xunit;

namespace Tests
{
    public class CyclicRotationTest
    {
        CyclicRotation cyclicRotation = new CyclicRotation();

        public CyclicRotationTest()
        {

        }

        [Fact]
        public void Test_NoRotation()
        {
            Assert.Equal(new int[] {1, 3, 5}, cyclicRotation.Solution(new int[] {1, 3, 5}, 0));
        }

        [Fact]
        public void Test_OneRotation()
        {
            Assert.Equal(new int[] {5, 1, 3}, cyclicRotation.Solution(new int[] {1, 3, 5}, 1));
        }

        [Fact]
        public void Test_TwoRotations()
        {
            Assert.Equal(new int[] {3, 5, 1}, cyclicRotation.Solution(new int[] {1, 3, 5}, 2));
        }

        [Fact]
        public void Test_MoreRotationsThanLength()
        {
            Assert.Equal(new int[] {3, 5, 1}, cyclicRotation.Solution(new int[] {1, 3, 5}, 5));
        }
    }
}