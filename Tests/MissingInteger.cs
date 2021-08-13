using Codility.MissingInteger;
using Xunit;

namespace Tests
{
    public class MissingIntegerTest
    {
        MissingInteger model = new MissingInteger();

        public MissingIntegerTest()
        {

        }

        [Fact]
        public void Test_Example()
        {
            Assert.Equal(5, model.Solution(new int[] {1, 3, 6, 4, 1 ,2}));
        }
    }
}