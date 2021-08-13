using Codility.MaxCounters;
using Xunit;

namespace Tests
{
    public class MaxCountersTest
    {
        MaxCounters model = new MaxCounters();

        public MaxCountersTest()
        {

        }

        [Fact]
        public void Test_Example()
        {
            Assert.Equal(new int[] { 3, 2, 2, 4, 2 }, model.Solution(5, new int[] { 3, 4, 4, 6, 1, 4, 4 }));
        }
    }
}