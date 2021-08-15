using Codility.NumberOfDiscIntersections;
using Xunit;

namespace Tests
{
    public class NumberOfDiscIntersectionsTest
    {
        NumberOfDiscIntersections model = new NumberOfDiscIntersections();

        public NumberOfDiscIntersectionsTest()
        {

        }

        [Fact]
        public void Test_OneDisk()
        {
            Assert.Equal(0, model.Solution(new int[] { 10 }));
        }

        [Fact]
        public void Test_TwoIntersectingDisks()
        {
            Assert.Equal(1, model.Solution(new int[] { 1, 1 }));
        }

        [Fact]
        public void Test_Example()
        {
            Assert.Equal(11, model.Solution(new int[] { 1, 5, 2, 1, 4, 0 }));
        }

        [Fact]
        public void Test_HugeRadius()
        {
            Assert.Equal(1, model.Solution(new int[] { 1, 2147483647 }));
        }
    }
}