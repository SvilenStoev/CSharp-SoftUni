using Exercises;
using System;
using Xunit;

namespace _02._09._Unit_Testing.test
{
    public class MyCalculatorTest
    {
        [Fact]
        public void SumShouldReturnCorrectResultWithTwoNumbers()
        {
            var calculator = new MyCalculator();

            var result = calculator.Sum(1, 2);

            Assert.Equal(3, result);
        }

        [Fact]
        public void SumShouldReturnCorrectResultWithManyNumbers()
        {
            var calculator = new MyCalculator();

            var result = calculator.Sum(1, 2, 3, 4, 5, 6);

            Assert.Equal(21, result);
        }

        [Fact]
        public void SumShouldReturnCorrectResultWithNegativeNumbers()
        {
            var calculator = new MyCalculator();

            var result = calculator.Sum(-1, -2, -3, -4, 5, 5);

            Assert.Equal(0, result);
        }

        [Fact]
        public void ProductShouldReturnCorrectResultWithTwoNumber()
        {
            var calculator = new MyCalculator();

            var result = calculator.Product(2, 3);

            Assert.Equal(6, result);
        }
    }
}
