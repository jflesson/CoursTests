using Microsoft.VisualStudio.TestTools.UnitTesting;
using AuthenticationFW;

namespace AuthenticationFW.MsTest
{
    [TestClass]
    public class AuthenticationTests
    {
        private Authentication authentication;

        [TestInitialize]
        public void BeforeEach()
        {
            authentication = new Authentication();
        }

        [TestMethod]
        public void ReturnTrue_WhenLoginAndPasswordIsCorrect()
        {
            string login = "correctLogin";
            string password = "password";

            bool result = authentication.Login(login, password);

            Assert.IsTrue(result);
        }
    }
}