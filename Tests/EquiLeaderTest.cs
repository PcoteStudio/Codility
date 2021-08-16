using Codility.EquiLeader;
using Xunit;

namespace Tests
{
    public class EquiLeaderTest
    {
        EquiLeader model = new EquiLeader();

        public EquiLeaderTest()
        {

        }

        [Fact]
        public void Test_NoLeader()
        {
            Assert.Equal(0, model.Solution(new int[] { 1, 0, 0, 1 }));
        }

        [Fact]
        public void Test_NoEquiLeader()
        {
            Assert.Equal(0, model.Solution(new int[] { 1, 0, 1, 0, 1 }));
        }

        [Fact]
        public void Test_TwoEquiLeaders()
        {
            Assert.Equal(2, model.Solution(new int[] { 4, 3, 4, 4, 4, 2 }));
        }
    }
}