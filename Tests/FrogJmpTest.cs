using Codility.FrogJmp;
using Xunit;

namespace Tests
{
    public class FrogJmpTest
    {
        FrogJmp model = new FrogJmp();

        public FrogJmpTest()
        {

        }

        [Fact]
        public void Test_XLargerThanY()
        {
            Assert.Equal(0, model.Solution(15, 14, 1));
        }

        [Fact]
        public void Test_XEqualToY()
        {
            Assert.Equal(0, model.Solution(15, 15, 1));
        }

        [Fact]
        public void Test_MultipleJumps()
        {
            Assert.Equal(5, model.Solution(10, 15, 1));
        }

        [Fact]
        public void Test_JumpPastTarget()
        {
            Assert.Equal(1, model.Solution(10, 15, 6));
        }
    }
}