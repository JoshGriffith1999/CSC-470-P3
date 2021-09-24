/*
 Old Version of the Project
I accidently created this for .NET core 3.1 instead of .NET Framework 4.7.2
Can Look at this one, the unit tests do not work with the other solution
 
 */
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
