using Codility.Dominator;
using Xunit;

namespace Tests
{
    public class DominatorTest
    {
        Dominator model = new Dominator();

        public DominatorTest()
        {

        }

        [Fact]
        public void Test_NoDominator()
        {
            Assert.Equal(-1, model.Solution(new int[] { 1, 1, 2, 3, 4 }));
        }

        [Fact]
        public void Test_WithDominator()
        {
            Assert.Equal(-1, model.Solution(new int[] { 1, 1, 2, 3, 3, 3, 3, 4 }));
        }
    }
}