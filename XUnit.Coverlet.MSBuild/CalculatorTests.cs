using Xunit;
using Calculator;

namespace Calculator.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void ShouldBeAbleToCreateCalculator()
        {
            Calculator calculator = new Calculator();
            Assert.NotNull(calculator);
        }

        [Fact]
        public void CheckAddOptionWithPlusValues()
        {
            double actual = Calculator.DoOperation(13, 45, "a");
            double expected = 58;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CheckAddOptionWithOneMinusValue()
        {
            double actual = Calculator.DoOperation(13, -45, "a");
            double expected = -32;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CheckAddOptionWithMinusValues()
        {
            double actual = Calculator.DoOperation(-13, -45, "a");
            double expected = -58;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CheckAddOptionWithZero()
        {
            double actual = Calculator.DoOperation(0, 45, "a");
            double expected = 45;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CheckSubtractOptionWithPlusResult()
        {
            double actual = Calculator.DoOperation(30, 24, "s");
            double expected = 6;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CheckSubtractOptionWithOneMinusResult()
        {
            double actual = Calculator.DoOperation(24, 30, "s");
            double expected = -6;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CheckSubtractOptionWithMinusValues()
        {
            double actual = Calculator.DoOperation(-43, -12, "s");
            double expected = -31;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CheckSubtractOptionWithZero()
        {
            double actual = Calculator.DoOperation(0, 0, "s");
            double expected = 0;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CheckMultiplyOptionWithPlusValues()
        {
            double actual = Calculator.DoOperation(35, 20, "m");
            double expected = 700;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CheckMultiplyOptionWithOneMinusValue()
        {
            double actual = Calculator.DoOperation(35, -20, "m");
            double expected = -700;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CheckMultiplyOptionWithMinusValues()
        {
            double actual = Calculator.DoOperation(-35, -20, "m");
            double expected = 700;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CheckMultiplyOptionWithZero()
        {
            double actual = Calculator.DoOperation(34, 0, "m");
            double expected = 0;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CheckDivideOptionWithPlusValues()
        {
            double actual = Calculator.DoOperation(150, 15, "d");
            double expected = 10;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CheckDivideOptionWithOneMinusValue()
        {
            double actual = Calculator.DoOperation(150, -15, "d");
            double expected = -10;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CheckDivideOptionWithMinusValues()
        {
            double actual = Calculator.DoOperation(-150, -15, "d");
            double expected = 10;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CheckDivideOptionWithZeroPositive()
        {
            double actual = Calculator.DoOperation(0, 23, "d");
            double expected = 0;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CheckDivideOptionWithZeroNegative()
        {
            double actual = Calculator.DoOperation(23, 0, "d");
            double expected = double.NaN;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CheckNanOperation()
        {
            double actual = Calculator.DoOperation(23, 0, "");
            double expected = double.NaN;
            Assert.Equal(expected, actual);
        }
    }
}