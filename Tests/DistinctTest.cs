using Codility.Distinct;
using Xunit;

namespace Tests
{
    public class DistinctTest
    {
        Distinct model = new Distinct();

        public DistinctTest()
        {

        }

        [Fact]
        public void Test_Example()
        {
            Assert.Equal(3, model.Solution(new int[] { 2, 1, 1, 2, 3, 1 }));
        }
    }
}