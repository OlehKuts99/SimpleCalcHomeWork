using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SimpleCalc
{
	[TestFixture]
	public class CalculatorTests
	{
        [SetUp]
        public void SetUp()
        {
            Calculator = new Calculator();
        }

        [TestCase(5, 10, 15)]
        [TestCase(-5, 10, 5)]
        [TestCase(-15, -5, -20)]
        public void Number1_Plus_number2(double number1, double number2, double expectedResult)
        {
            // Arrange
            Calculator.Number1 = number1;
            Calculator.Number2 = number2;

            // Act
            double actualResult = Calculator.Add();

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(5, 2, 3)]
        [TestCase(-5, 10, -15)]
        [TestCase(-15, -12, -3)]
        public void Number1_Subtract_number2(double number1, double number2, double expectedResult)
        {
            // Arrange
            Calculator.Number1 = number1;
            Calculator.Number2 = number2;

            // Act
            double actualResult = Calculator.Subtract();

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(4, 3, 12)]
        [TestCase(-5, 4, -20)]
        [TestCase(-15, -2, 30)]
        [TestCase(4, 0, 0)]
        public void Number1_Multiply_number2(double number1, double number2, double expectedResult)
        {
            // Arrange
            Calculator.Number1 = number1;
            Calculator.Number2 = number2;

            // Act
            double actualResult = Calculator.Multiply();

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(-50, -25, 2)]
        [TestCase(20, 4, 5)]
        [TestCase(5, 20, 0.25)]
        [TestCase(0, 5, 0)]
        public void Number1_Divide_number2(double number1, double number2, double expectedResult)
        {
            // Arrange
            Calculator.Number1 = number1;
            Calculator.Number2 = number2;

            // Act
            double actualResult = Calculator.Divide();

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Number_Divide_By_Zero_Exception()
        {
            // Arrange
            Calculator.Number1 = 5;
            Calculator.Number2 = 0;

            // Act

            // Assert
            Assert.That(() => Calculator.Divide(),
            Throws.Exception
              .TypeOf<DivideByZeroException>());
        }

        private Calculator Calculator { get; set; }
	}
}
