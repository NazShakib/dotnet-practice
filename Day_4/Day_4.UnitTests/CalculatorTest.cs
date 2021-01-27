using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Day_4;

namespace Day_4.UnitTests
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void Correct_Add_ReturnValid()
        {
            var calculate = new Calculator();
            calculate.Number1 = 10;
            calculate.Number2 = 20;
            var addResult = calculate.Add();
            Assert.AreEqual(addResult, 30);
        }

        [TestMethod]
        public void Correct_Substruct_ReturnValid()
        {
            var calculate = new Calculator();
            calculate.Number1 = 30;
            calculate.Number2 = 20;
            var addResult = calculate.Substuct();
            Assert.AreEqual(addResult, 10);
        }

        [TestMethod]
        public void Correct_Divided_ReturnValid()
        {
            var calculate = new Calculator();
            calculate.Number1 = 30;
            calculate.Number2 = 15;
            var addResult = calculate.Divided();
            Assert.AreEqual(addResult, 2);
        }

        [TestMethod]
        public void Correct_Multiplication_ReturnValid()
        {
            var calculate = new Calculator();
            calculate.Number1 = 3;
            calculate.Number2 = 2;
            var addResult = calculate.Multiplication();
            Assert.AreEqual(addResult, 6);
        }

        [TestMethod]
        public void String_Add_ReturnException()
        {
            var calculate = new Calculator();
            calculate.Number1 = 'a';
            calculate.Number2 = 'b';
            var addResult = calculate.Add();
            try
            {
                Assert.AreEqual(addResult,10);
            }
            catch (Exception)
            {

                throw new Exception("Invalid");
            }
        }

        [TestMethod]
        public void DividedBy_Zero_exception()
        {
            var calculate = new Calculator();
            calculate.Number1 = 10;
            calculate.Number2 = 0;
            var result = calculate.Divided();
            try
            {
                Assert.IsNull(result);
            }
            catch (Exception)
            {
                throw new Exception("Invalid");
            }
        }
    }
}
