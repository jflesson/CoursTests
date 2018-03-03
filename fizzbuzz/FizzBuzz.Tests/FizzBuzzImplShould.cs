using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzz;
namespace FizzBuzz.Tests
{
    [TestClass]
    public class FizzBuzzImplShould
    {
        private FizzBuzzImpl fb;

        [TestInitialize]
        public void BeforeEach()
        {
            this.fb = new FizzBuzzImpl();
        }

        [TestMethod]
        public void ReturnFizz_WhenValueCanDivisedBy3()
        {
            //Arrange
            int request = 3;

            //Act
            string result = this.fb.FizzBuzz(request);

            //Assert
            Assert.AreEqual("Fizz", result);
        }

        [TestMethod]
        public void ReturnBuzz_WhenValueCanDivisedBy5()
        {
            //Arrange
            int request = 5;

            //Act
            string result = this.fb.FizzBuzz(request);

            //Assert
            Assert.AreEqual("Buzz", result);
        }

        [TestMethod]
        public void ReturnFizzBuzz_WhenValueCanDivisedBy3And5()
        {
            //Arrange
            int request = 15;

            //Act
            string result = this.fb.FizzBuzz(request);

            //Assert
            Assert.AreEqual("FizzBuzz", result);
        }

        [TestMethod]
        public void ReturnValue_WhenValueCantDivisedBy3And5()
        {
            //Arrange
            int request = 8;

            //Act
            string result = this.fb.FizzBuzz(request);

            //Assert
            Assert.AreEqual("8", result);
        }
    }
}
