using System;
using Xunit;
using AreaMethod;

namespace AreaMethodXUnitTest
{
    public class UnitTestSuit1
    {

        [Fact]
        public void RectangleAndSquareArea()
        {
            AreaMethodClass RectangleAndSquareAreaTest = new AreaMethodClass();

            int result = Convert.ToInt32(RectangleAndSquareAreaTest.RectangleAndSquareArea(3, 5));

            Assert.Equal(15, result);
        }

        [Fact]

        public void CircleArea()
        {
            AreaMethodClass CircleAreTest = new AreaMethodClass();

            int result = Convert.ToInt32(CircleAreTest.CircleArea(3));

            Assert.Equal(28, result);
        }

        [Fact]

        public void TriangleArea()
        {
            AreaMethodClass TriangleAreaTest = new AreaMethodClass();

            int result = Convert.ToInt32(TriangleAreaTest.TriangleArea(2.34, 3.44));

            Assert.Equal(4, result);
        }

        [Fact]
        public void TrapezoidArea()
        {
            AreaMethodClass TrapezoidAreaTest = new AreaMethodClass();

            int result = Convert.ToInt32(TrapezoidAreaTest.TrapezoidArea(2.34, 3.44, 3));

            Assert.Equal(9, result);

        }

        [Fact]
        public void ParallelogramArea()
        {
            AreaMethodClass ParallelogramAreaTest = new AreaMethodClass();

            int result = Convert.ToInt32(ParallelogramAreaTest.ParallelogramArea(100, 100));

            Assert.Equal(10000, result);
        }
    }
}
