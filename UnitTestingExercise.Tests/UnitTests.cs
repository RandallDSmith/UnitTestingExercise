using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)]
        [InlineData(3, 4, 7, 14)]
        [InlineData(1, 1, 1, 3)]
        [InlineData(5, 5, 5, 15)]//Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            Calculator unitTests = new Calculator();

            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual
            var actual = Calculator.AddMethod(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(6, 2, 4)]
        [InlineData(10, 7, 3)]
        [InlineData(20, 10, 10)]
        [InlineData(30, 5, 25)]//Add test data <-------
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            Calculator unitTests2 = new Calculator();
            //Act
            var actualSub = Calculator.SubMethod(minuend, subtrhend);
            //Assert
            Assert.Equal(expected, actualSub);
        }

        [Theory]
        [InlineData(2, 5, 10)]
        [InlineData(5, 5, 25)]
        [InlineData(6, 2, 12)]
        [InlineData(10, 10, 100)]//Add test data <-------
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            Calculator unitTests3 = new Calculator();
            //Act
            var actualMult = Calculator.MultMethod(num1, num2);
            //Assert
            Assert.Equal(expected, actualMult);
        }

        [Theory]
        [InlineData(10, 2, 5)]
        [InlineData(12, 2, 6)]
        [InlineData(24, 12, 2)]
        [InlineData(30, 5, 6)]//Add test data <-------
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            Calculator unitTest4 = new Calculator();
            //Act
            var actualDiv = Calculator.DivideMethod(num1, num2);
            //Assert
            Assert.Equal(expected, actualDiv);
        }

    }
}
