using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestFakeAppUserRepository
{
    [TestClass]
    public class Login
    {
        [TestMethod]
        public void LoginWithCorrectCredentialsSuccessful()
        {
            //Arrange
            const string userName = "john";
            const string password = "go";
            FakeAppUserRepository EmpRepository = new FakeAppUserRepository();
            //Act
            bool correctCredentials = EmpRepository.Login(userName,password);
            //Assert
            Assert.IsTrue(correctCredentials);
        }
        public void LoginWithIncorrectCredentialsFail()
        {
            //Arrange
            const string userName = "john";
            const string password = "notgo";
            FakeAppUserRepository EmpRepository = new FakeAppUserRepository();
            //Act
            bool incorrectCredentials = EmpRepository.Login(userName, password);
            //Assert
            Assert.IsFalse(incorrectCredentials);
        }


    }
}
