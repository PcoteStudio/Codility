using Codility.Triangle;
using Xunit;

namespace Tests
{
    public class TriangleTest
    {
        Triangle model = new Triangle();

        public TriangleTest()
        {

        }

        [Fact]
        public void Test_True()
        {
            Assert.Equal(1, model.Solution(new int[] {10, 2, 5, 1, 8, 20}));
        }

        [Fact]
        public void Test_False()
        {
            Assert.Equal(0, model.Solution(new int[] {10, 50, 5, 1}));
        }
    }
}