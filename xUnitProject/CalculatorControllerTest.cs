using CalculatorInfrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace xUnitProject
{
    public class CalculatorControllerTest
    {
        private CalculatorService _unitTesting = null;
        public CalculatorControllerTest()
        {
            if (_unitTesting == null)
            {
                this._unitTesting = new CalculatorService();
            }
        }

        [Fact]
        public void Add()
        {
            //Arrange
            int numOne = 3;
            int numTwo = 3;
            int expected = 6;

            //Act
            double actual  = _unitTesting.Add(numOne, numTwo);

            //Assert
            Assert.Equal(expected, actual , 0);
        }

        [Fact]
        public void Substract()
        {
            //Arrange 
            int numOne = 5;
            int numTwo = 5;
            int expected = 0;

            //Act
            var actual  = _unitTesting.Subtract(numOne, numTwo);

            //Assert
            Assert.Equal(expected, actual , 0);
        }

        [Theory(DisplayName = "Maths- Divided with parameters")]
        [InlineData(40, 8, 5)]
        public void Divion(double value1, double value2, double value3)
        {
            //Arrange
            double numOne = value1;
            double numTwo = value2;
            double expected = value3;

            //Act
            var actual = _unitTesting.Divide(numOne, numTwo);

            //Assert
            Assert.Equal(expected, actual, 0);

        }
        [Fact]
        public void Multiply()
        {
            //Arrange
            int numOne = 5;
            int numTwo = 2;
            int expected = 10;

            //Act
            var actual  = _unitTesting.Multiply(numOne, numTwo);

            //Assert
            Assert.Equal(expected,actual , 0);
        }

        [Fact(DisplayName = "Maths - Divide by Zero Exception")]
        public void DivideByZeroException()
        {
            //arrange
            double a = 100;
            double b = 0;

            //act
            Action act = () => _unitTesting.Divide(a, b);

            //assert
            Assert.Throws<DivideByZeroException>(act);
        }
    }
}
