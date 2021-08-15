using Codility.CountDiv;
using Xunit;

namespace Tests
{
    public class CountDivTest
    {
        CountDiv model = new CountDiv();

        public CountDivTest()
        {

        }

        [Fact]
        public void Test_KTooHigh()
        {
            Assert.Equal(0, model.Solution(43, 55, 14));
        }

        [Fact]
        public void Test_OneOccurrence()
        {
            Assert.Equal(1, model.Solution(42, 55, 14));
        }

        [Fact]
        public void Test_TwoOccurrences()
        {
            Assert.Equal(2, model.Solution(42, 56, 14));
        }

        [Fact]
        public void Test_ThousandOccurrences()
        {
            Assert.Equal(1000, model.Solution(1, 2000, 2));
        }

        [Fact]
        public void Test_AIsZero()
        {
            Assert.Equal(100, model.Solution(0, 200, 2));
        }
    }
}