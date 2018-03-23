using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzz;
namespace FizzBuzz.Tests
{
    [TestClass]
    public class Class1
    {
        [TestMethod]
        public void DoitRetournerFizz()
        {
            FizzBuzzImpl fb = new FizzBuzzImpl();
            int request = 3;

            string result = fb.FizzBuzz(request);

            Assert.AreEqual("Fizz", result);
        }

        [TestMethod]
        public void DoitRetournerBuzz()
        {
            FizzBuzzImpl fb = new FizzBuzzImpl();
            int request = 5;

            string result = fb.FizzBuzz(request);

            Assert.AreEqual("Buzz", result);
        }

        [TestMethod]
        public void DoitRetournerFizzBuzz()
        {
            FizzBuzzImpl fb = new FizzBuzzImpl();
            int request = 15;

            string result = fb.FizzBuzz(request);

            Assert.AreEqual("FizzBuzz", result);
        }

        [TestMethod]
        public void DoitRetournerLentree()
        {
            FizzBuzzImpl fb = new FizzBuzzImpl();
            int request = 1;

            string result = fb.FizzBuzz(request);

            Assert.AreEqual("1", result);
        }
    }
}
