using Codility.Flags;
using Xunit;

namespace Tests
{
    public class FlagsTest
    {
        Flags model = new Flags();

        public FlagsTest()
        {

        }

        [Fact]
        public void Test_Example()
        {
            Assert.Equal(3, model.Solution(new int[] { 1, 5, 3, 4, 3, 4, 1, 2, 3, 4, 6, 2 }));
        }
    }
}