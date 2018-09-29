using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Calculator.Library
{
    [TestFixture]
    class NUnitTestClass
    {
        [TestCase]
        public void Addition_Test()
        {
            //Arrange section: Initialize the variables and set its value
            int expectedResult = 24;
            int num1 = 20;
            int num2 = 4;

            //Act section: call the intended method that we want to test
            int actionResult = CalculationOperation.Add(num1, num2);

            //Assert section - We verify weather our test suceeded or not using Assert class
            Assert.AreEqual(expectedResult, actionResult);
            Console.WriteLine("This is test method for addition");
        }


        [TestCase]
        public void Substraction_Test()
        {
            //Arrange section: Initialize the variables and set its value
            int expectedResult = 16;
            int num1 = 20;
            int num2 = 4;

            //Act section: call the intended method that we want to test
            int actionResult = CalculationOperation.Substract(num1, num2);

            //Assert section - We verify weather our test suceeded or not using Assert class
            Assert.AreEqual(expectedResult, actionResult);
            Console.WriteLine("This is test method for substraction");
        }

        [TestCase]
        public void Multiplication_Test()
        {
            //Arrange section: Initialize the variables and set its value
            int expectedResult = 80;
            int num1 = 20;
            int num2 = 4;

            //Act section: call the intended method that we want to test
            int actionResult = CalculationOperation.Multiply(num1, num2);

            //Assert section - We verify weather our test suceeded or not using Assert class
            Assert.AreEqual(expectedResult, actionResult);
            Console.WriteLine("This is test method for multiplication");
        }

        [TestCase]
        public void Division_Test()
        {
            //Arrange section: Initialize the variables and set its value
            int expectedResult = 5;
            int num1 = 20;
            int num2 = 4;

            //Act section: call the intended method that we want to test
            int actionResult = CalculationOperation.Divide(num1, num2);

            //Assert section - We verify weather our test suceeded or not using Assert class
            Assert.AreEqual(expectedResult, actionResult);
            Console.WriteLine("This is test method for division");
        }

    }
}
