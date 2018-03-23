using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringCalculator;

namespace StringCalculator.Tests
{
    [TestClass]
    public class Calculator_AddShould
    {
        private Calculator calculator;
        public void BeforeEach()
        {
            calculator = new Calculator();
        }

        [TestMethod]
        public void return0_WhenValueEmpty()
        {
            int result = calculator.Add("");

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void return1_WhenValueIs1()
        {
            int result = calculator.Add("1");

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void return3_WhenValueIs1Comma2()
        {
            int result = calculator.Add("1,2");

            Assert.AreEqual(3, result);
        }
    }
}
