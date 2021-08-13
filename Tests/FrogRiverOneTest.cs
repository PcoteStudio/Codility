using Codility.FrogRiverOne;
using Xunit;

namespace Tests
{
    public class FrogRiverOneTest
    {
        FrogRiverOne model = new FrogRiverOne();

        public FrogRiverOneTest()
        {

        }

        [Fact]
        public void Test_Never()
        {
            Assert.Equal(-1, model.Solution(3, new int[]{1, 2, 2, 2, 2}));
        }

        [Fact]
        public void Test_0()
        {
            Assert.Equal(0, model.Solution(0, new int[]{}));
        }

        [Fact]
        public void Test_Repetition()
        {
            Assert.Equal(6, model.Solution(5, new int[]{1, 3, 1, 4, 2, 3, 5}));
        }
    }
}