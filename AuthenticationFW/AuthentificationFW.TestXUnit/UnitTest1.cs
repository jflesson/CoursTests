using System;
using Xunit;
using AuthenticationFW;

namespace AuthentificationFW.TestXUnit
{
    public class AuthenticationTests
    {
        [Fact]
        public void ReturnTrue_WhenLoginAndPasswordIsCorrect()
        {
            Authentication authentication = new Authentication();

            string login = "correctLogin";
            string password = "password";

            bool result = authentication.Login(login, password);

            Assert.True(result);
        }
    }
}
