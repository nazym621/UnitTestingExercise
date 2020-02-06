using System;
using Xunit;
using UnitTestingExercise;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(1,1,1,3)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            var addTest = new UnitTestMethods();
            //Act
            var actual = addTest.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(3,2,1)]
        public void Subtract(int minuend, int subtrhend, int expected)
        {
            //Arrange
            var subTest = new UnitTestMethods();

            //Act
            var actual = subTest.Subtract(minuend - subtrhend);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(2,4,8)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            var mulTest = new UnitTestMethods();

            //Act
            var actual = mulTest.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(10,5,2)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            var divTest = new UnitTestMethods();

            //Act
            var actual = divTest.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void YourMethodName()
        {
            //Arrange

            //Act

            //Assert

        }

        [Fact]
        public void YourMethodName2()
        {
            //Arrange

            //Act

            //Assert
        }
    }
}
