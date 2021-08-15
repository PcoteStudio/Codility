using Codility.PassingCars;
using Xunit;

namespace Tests
{
    public class PassingCarsTest
    {
        PassingCars model = new PassingCars();

        public PassingCarsTest()
        {

        }

        [Fact]
        public void Test_Example()
        {
            Assert.Equal(5, model.Solution(new int[] { 0, 1, 0, 1, 1 }));
        }
    }
}