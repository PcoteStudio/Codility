using Codility.MaxProfit;
using Xunit;

namespace Tests
{
    public class MaxProfitTest
    {
        MaxProfit model = new MaxProfit();

        public MaxProfitTest()
        {

        }

        [Fact]
        public void Test_Unordered()
        {
            Assert.Equal(356, model.Solution(new int[] { 23171, 21011, 21123, 21366, 21013, 21367 }));
        }

        [Fact]
        public void Test_NoProfit()
        {
            Assert.Equal(0, model.Solution(new int[] { 23171, 21367 }));
        }

        [Fact]
        public void Test_Ordered()
        {
            Assert.Equal(356, model.Solution(new int[] { 21011, 21367 }));
        }
    }
}