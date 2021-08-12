using Codility.OddOccurrencesInArray;
using Xunit;

namespace Tests
{
    public class OddOccurrencesInArrayTest
    {
        OddOccurrencesInArray model = new OddOccurrencesInArray();

        public OddOccurrencesInArrayTest()
        {

        }

        [Fact]
        public void Test_EmptyArray()
        {
            Assert.Equal(0, model.Solution(new int[] { }));
        }

        [Fact]
        public void Test_OneOccurrence()
        {
            Assert.Equal(2, model.Solution(new int[] { 1, 1, 2, 3, 3, 3, 3 }));
        }

        [Fact]
        public void Test_ThreeOccurrences()
        {
            Assert.Equal(2, model.Solution(new int[] { 1, 1, 2, 2, 2, 3, 3, 3, 3 }));
        }
    }
}