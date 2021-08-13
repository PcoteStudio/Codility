using Codility.PermMissingElem;
using Xunit;

namespace Tests
{
    public class PermMissingElemTest
    {
        PermMissingElem model = new PermMissingElem();

        public PermMissingElemTest()
        {

        }

        [Fact]
        public void Test_Ordered()
        {
            Assert.Equal(4, model.Solution(new int[] {1, 2, 3, 5}));
        }

        [Fact]
        public void Test_Unordered()
        {
            Assert.Equal(2, model.Solution(new int[] {3, 6, 5, 1, 4}));
        }

        [Fact]
        public void Test_Smallest()
        {
            Assert.Equal(1, model.Solution(new int[] {2}));
        }
    }
}