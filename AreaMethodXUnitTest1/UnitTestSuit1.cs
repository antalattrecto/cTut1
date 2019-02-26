using System;
using Xunit;
using AreaMethod;
using CSProject;


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

    public class CSUnitTests
    {
        [Fact]

        public void StaffCalculatePay()
        {
            Staff obj = new Staff("John", 20);
            obj.HoursWorked = 500;

            obj.CalculatePay();

            Assert.Equal(10000, obj.TotalPay);

        }
        [Fact]

        public void ManagerCalculatePay()
        {
            Manager obj = new Manager("John");

            Assert.Equal(0, obj.Allowance);

            obj.HoursWorked = 159;

            obj.CalculatePay();

            Assert.Equal(obj.TotalPay, obj.BasicPay);


        }

        [Fact]
        public void ManagerCalculatePayOver160()
        {
            Manager obj = new Manager("John");

            Assert.Equal(0, obj.Allowance);

            obj.HoursWorked = 161;

            obj.CalculatePay();

            Assert.NotEqual(obj.TotalPay, obj.BasicPay);


        }


        [Fact]

        public void AdminCalculatePay()
        {
            Admin obj = new Admin("John");

            obj.HoursWorked = 159;

            obj.CalculatePay();

            Assert.Equal(obj.TotalPay, obj.BasicPay);


        }

        [Fact]
        public void AdminCalculatePayOver160()
        {
            Admin obj = new Admin("John");

            obj.HoursWorked = 161;

            obj.CalculatePay();

            Assert.NotEqual(obj.TotalPay, obj.BasicPay);


        }

    }

}
