using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        [InlineData(-2, 2, 5, 5)] //Add test data <-------
        [InlineData(0, 0, 0, 0)] //Add test data <-------
        [InlineData(23581321, 12318532, 100, 35899953)] //Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            Calculator calcAdd = new Calculator();


            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual
            var actual = calcAdd.Add(num1, num2, num3);


            //Assert
            //Assert.Equal(expected, actual);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(9, 3, 6)]//Add test data <-------
        [InlineData(0, 0, 0)]//Add test data <-------
        [InlineData(-1, -9, 8)]//Add test data <-------
        [InlineData(1234567890, 1234567890, 0)]//Add test data <-------
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            Calculator calcSub = new Calculator();

            //Act
            var actual = calcSub.Subtract(minuend, subtrhend);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, 1, 2)]//Add test data <-------
        [InlineData(-2, -1, 2)]//Add test data <-------
        [InlineData(45235789, -1, -45235789)]//Add test data <-------
        [InlineData(0, 0, 0)]//Add test data <-------
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            Calculator calcMult = new Calculator();

            //Act
            var actual = calcMult.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(4, 2, 2)]//Add test data <-------
        [InlineData(28, 7, 4)]//Add test data <-------
        [InlineData(0, 7, 0)]//Add test data <-------
        [InlineData(1048576, 1024, 1024)] // 1 Terrabyte, Add test data <-------
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            Calculator calcDivide = new Calculator();

            //Act
            var actual = calcDivide.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
