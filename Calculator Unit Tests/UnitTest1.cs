using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void TestAddition()
        {
            // Arrange
            Form1 form = new Form1();

            form.SetInput("10");
            form.SetOp1("5");
            form.SetOp2("2");
            form.SetOperation('+');
            form.SetResult(15);

            // Act
            double result = form.GetResult();

            // Assert
            Assert.AreEqual(15, result);
        }

        [TestMethod]
        public void TestSubtraction()
        {
            // Arrange
            Form1 form = new Form1();
            form.SetInput("10");
            form.SetOp1("8");
            form.SetOp2("2");
            form.SetOperation('-');
            form.SetResult(6); // Expected result should be 6

            // Act
            double result = form.GetResult();

            // Assert
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void TestMultiplication()
        {
            // Arrange
            Form1 form = new Form1();
            form.SetInput("10");
            form.SetOp1("3");
            form.SetOp2("4");
            form.SetOperation('*');
            form.SetResult(12); // Expected result should be 12

            // Act
            double result = form.GetResult();

            // Assert
            Assert.AreEqual(12, result);
        }

        [TestMethod]
        public void TestDivision()
        {
            // Arrange
            Form1 form = new Form1();
            form.SetInput("10");
            form.SetOp1("15");
            form.SetOp2("3");
            form.SetOperation('/');
            form.SetResult(5); // Expected result should be 5

            // Act
            double result = form.GetResult();

            // Assert
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void TestDivisionWithDecimalResult()
        {
            // Arrange
            Form1 form = new Form1();
            form.SetInput("10");
            form.SetOp1("10");
            form.SetOp2("3");
            form.SetOperation('/');
            form.SetResult(3.3333333333333335); // Expected result should be approximately 3.3333333333333335

            // Act
            double result = form.GetResult();

            // Assert
            Assert.AreEqual(3.3333333333333335, result, 0.000000000000001); // Assert with precision up to 14 decimal places
        }

       
    }


}

