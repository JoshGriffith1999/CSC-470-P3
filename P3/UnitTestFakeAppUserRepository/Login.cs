/*
 Look at this one
This is the correct version using the .NET Framework 4.7.2
Unit Tests work with the other project
 */
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using P3;

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
            bool correctCredentials = EmpRepository.Login(userName, password);
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
