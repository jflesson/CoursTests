using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AuthenticationFW;
using Moq;

namespace UnitTestProject1
{
    [TestClass]
    public class AuthenticationTests
    {
        private Authentication authentication;
        private Mock<IRsaEncryption> rsaEncryption;
        private Mock<IUserStore> userStore;

        [TestInitialize]
        public void BeforeEach()
        {
            rsaEncryption = new Mock<IRsaEncryption>();
            userStore = new Mock<IUserStore>();
         
            authentication = new Authentication(userStore.Object, rsaEncryption.Object);
        }

        [TestMethod]
        public void ReturnTrue_WhenLoginAndPasswordIsCorrect()
        {
            userStore.Setup(o => o.Get("correctLogin")).Returns(new User()
            {
                Login = "correctLogin",
                Password = "password"
            });
            rsaEncryption.Setup(o => o.Encrypt("password")).Returns("password");
            string login = "correctLogin";
            string password = "password";

            bool result = authentication.Login(login, password);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ReturnFalse_WhenLoginIsIncorrect()
        {
            string login = "badLogin";
            string password = "password";

            bool result = authentication.Login(login, password);

            Assert.IsFalse(result);
        }
    }
}
