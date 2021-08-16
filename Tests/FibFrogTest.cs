using Codility.FibFrog;
using Xunit;

namespace Tests
{
    public class FibFrogTest
    {
        FibFrog model = new FibFrog();

        public FibFrogTest()
        {

        }

        [Fact]
        public void Test_Example()
        {
            Assert.Equal(3, model.Solution(new int[] { 0, 0, 0, 1, 1, 0, 1, 0, 0, 0, 0 }));
        }

        [Fact]
        public void Test_OneLeaf()
        {
            Assert.Equal(1, model.Solution(new int[] { 1 }));
        }

        [Fact]
        public void Test_NoPath()
        {
            Assert.Equal(-1, model.Solution(new int[] { 0, 0, 0 }));
        }
    }
}