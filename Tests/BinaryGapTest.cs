using System;
using Codility.BinaryGap;
using Xunit;

namespace Tests
{
    public class BinaryGapTest
    {
        BinaryGap binaryGap = new BinaryGap();

        public BinaryGapTest()
        {

        }

        [Fact]
        public void Test_NoGapLeading1()
        {   // 1000
            Assert.Equal(0, binaryGap.Solution(8));
        }

        [Fact]
        public void Test_NoGapTrailing1()
        {   // 0001
            Assert.Equal(0, binaryGap.Solution(1));
        }

        [Fact]
        public void Test_NoGapAllTrue()
        {   // 1111
            Assert.Equal(0, binaryGap.Solution(15));
        }

        [Fact]
        public void Test_NoGapAllFalse()
        {   // 0000
            Assert.Equal(0, binaryGap.Solution(0));
        }

        [Fact]
        public void Test_TwoGapsSmallFirst()
        {   // 10010001
            Assert.Equal(3, binaryGap.Solution(145));
        }

        [Fact]
        public void Test_TwoGapsLargeFirst()
        {   // 10001001
            Assert.Equal(3, binaryGap.Solution(137));
        }

        [Fact]
        public void Test_MultipleTrueInARow()
        {   // 1110111
            Assert.Equal(1, binaryGap.Solution(119));
        }
    }
}