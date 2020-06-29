using System;
using Xunit;

namespace MySuperApp.Test
{
    public class StatisticsCalculatorTest
    {
        [Fact]
        public void TestSumTwoNumbers()
        {
            var calculator = new StatisticsCalculator();
            calculator.Add(5);
            calculator.Add(7);
            var sum = calculator.Sum();
            Assert.Equal(12, sum);
        }

        [Fact]
        public void TestSumTwoNumbersMinus()
        {
            var calculator = new StatisticsCalculator();
            calculator.Add(-5);
            calculator.Add(-7);
            var sum = calculator.Sum();
            Assert.Equal(-12, sum);
        }

        [Fact]
        public void TestSumNoNumbers()
        {
            var calculator = new StatisticsCalculator();
            var sum = calculator.Sum();
            Assert.Equal(0, sum);
        }

        [Fact]
        public void TestDivisionTwoNumbers()
        {
            var calculator = new StatisticsCalculator();
            calculator.Add(6);
            calculator.Add(3);
            var result = calculator.Divide();
            Assert.Equal(2, result);
        }

        [Fact]
        public void TestDivisionOneNumber()
        {
            var calculator = new StatisticsCalculator();
            calculator.Add(6);
            var result = calculator.Divide();
            Assert.Equal(6, result);
        }

        [Fact]
        public void TestDivisionMultipleNumbers()
        {
            var calculator = new StatisticsCalculator();
            calculator.Add(10);
            calculator.Add(5);
            calculator.Add(2);
            var result = calculator.Divide();
            Assert.Equal(1, result);
        }

        [Fact]
        public void TestDivisionByZero()
        {
            var calculator = new StatisticsCalculator();
            calculator.Add(10);
            calculator.Add(0);
            var result = calculator.Divide();
            Assert.Equal(1, result);
        }

        [Fact]
        public void TestDivisionNoNumbers()
        {
            var calculator = new StatisticsCalculator();
            var result = calculator.Divide();
            Assert.Equal(1, result);
        }
    }
}
