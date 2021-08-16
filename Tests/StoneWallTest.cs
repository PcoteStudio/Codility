using Codility.StoneWall;
using Xunit;

namespace Tests
{
    public class StoneWallTest
    {
        StoneWall model = new StoneWall();

        public StoneWallTest()
        {

        }

        [Fact]
        public void Test_UpAndDown()
        {
            Assert.Equal(7, model.Solution(new int[] { 8, 7, 7, 8, 9, 4, 5, 8, 8 }));
        }

        [Fact]
        public void Test_SingleBlock()
        {
            Assert.Equal(1, model.Solution(new int[] { 7 }));
        }

        [Fact]
        public void Test_LongSingleBlock()
        {
            Assert.Equal(1, model.Solution(new int[] { 7, 7, 7, 7, 7 }));
        }

        [Fact]
        public void Test_Down()
        {
            Assert.Equal(6, model.Solution(new int[] { 9, 8, 7, 6, 5, 4 }));
        }

        [Fact]
        public void Test_Up()
        {
            Assert.Equal(6, model.Solution(new int[] { 4, 5, 6, 7, 8, 9 }));
        }
    }
}