using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace Test
{
    [TestClass]
    public class CalculatorTest
    {


        [TestMethod]
        public void TestAddition()
        {
            int a = 1;
            int b = 2;
            int result = Calculator.addition(a, b);
            Assert.AreEqual(3, result, 0.001);
        }


        [TestMethod]
        public void TestMultiplication()
        {
            int a = 1;
            int b = 2;
            int result = Calculator.multiplication(a, b);
            Assert.AreEqual(2, result, 0.001);
        }

        [TestMethod]
        public void TestDivision()
        {
            int a = 1;
            int b = 2;
            double result = Calculator.division(a, b);
            Assert.AreEqual(0.5, result, 0.001);
        }

        [TestMethod]
        public void TestDivisionByZero()
        {
            int a = 1;
            int b = 0;
            double result = Calculator.division(a, b);
            Assert.AreEqual(0, result, 0.001);
        }

        [TestMethod]
        public void TestSubstraction()
        {
            int a = 1;
            int b = 2;
            double result = Calculator.substraction(a, b);
            Assert.AreEqual(-1, result, 0.001);
        }
    }
}
