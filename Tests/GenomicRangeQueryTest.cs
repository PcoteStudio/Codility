using Codility.GenomicRangeQuery;
using Xunit;

namespace Tests
{
    public class GenomicRangeQueryTest
    {
        GenomicRangeQuery model = new GenomicRangeQuery();

        public GenomicRangeQueryTest()
        {

        }

        [Fact]
        public void Test_OneCharacter()
        {
            Assert.Equal(new int[] {2, 2, 2}, model.Solution("C", new int[] {0, 0, 0}, new int[] {0, 0, 0}));
        }

        [Fact]
        public void Test_TwoCharacters()
        {
            Assert.Equal(new int[] {1, 1, 2}, model.Solution("AC", new int[] {0, 0, 1}, new int[] {0, 1, 1}));
        }

        [Fact]
        public void Test_AlmostAllSameCharacter()
        {
            Assert.Equal(new int[] {4, 1, 1}, model.Solution("TTTTTTTTTTTATTTT", new int[] {0, 0, 11}, new int[] {10, 11, 11}));
        }
    }
}