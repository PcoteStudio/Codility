using Codility.PermCheck;
using Xunit;

namespace Tests
{
    public class PermCheckTest
    {
        PermCheck model = new PermCheck();

        public PermCheckTest()
        {

        }

        [Fact]
        public void Test_UnorderedValid()
        {
            Assert.Equal(1, model.Solution(new int[] {4, 1, 3, 2}));
        }

        [Fact]
        public void Test_OrderedInvalid()
        {
            Assert.Equal(0, model.Solution(new int[] {2, 3, 4}));
        }
    }
}