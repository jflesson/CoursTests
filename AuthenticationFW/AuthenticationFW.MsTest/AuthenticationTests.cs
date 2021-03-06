﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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

        [TestMethod]
        public void ReturnFalse_WhenLoginIsIncorrect()
        {
            string login = "badLogin";
            string password = "password";

            bool result = authentication.Login(login, password);

            Assert.IsFalse(result);
        }

        public int[] Filter(){
            int[] numbers = new int[7] { 0, 1, 2, 3, 4, 5, 6 };

            // 2. Query creation.
            // numQuery is an IEnumerable<int>
            var numQuery =
                from num in numbers
                where (num % 2) == 0
                select num;
            return numQuery;
        }
    }
}