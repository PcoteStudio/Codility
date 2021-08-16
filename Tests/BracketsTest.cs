using Codility.Brackets;
using Xunit;

namespace Tests
{
    public class BracketsTest
    {
        Brackets model = new Brackets();

        public BracketsTest()
        {

        }

        [Fact]
        public void Test_True()
        {
            Assert.Equal(1, model.Solution("{a[(b)()]a}"));
        }

        [Fact]
        public void Test_False()
        {
            Assert.Equal(0, model.Solution("(b[)(a)]"));
        }

        [Fact]
        public void Test_NoClosing()
        {
            Assert.Equal(0, model.Solution("{{{"));
        }

        [Fact]
        public void Test_NoOpening()
        {
            Assert.Equal(0, model.Solution("]]]"));
        }
    }
}