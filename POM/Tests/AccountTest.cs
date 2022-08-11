using POM.Helpers;
using NUnit.Framework;
using FluentAssertions;

namespace POM.Tests
{
    [TestFixture]
    public class AccountTest : BaseTest
    {
        [Test]
        [TestCase(Constants.GoodAccountEmail, Constants.GoodAccountPassword, Constants.AsdAccountHelloMessage)]
        
        public void LoginPositive(string email, string pass, string message)
        {
            Pages.Header.GoToLogIn();

            Pages.LoginPage.LogIn(email, pass);

            Pages.AccountPage.VerifyHelloMessage(message).Should().BeTrue();
        }

        [Test]
        [TestCase(Constants.GoodAccountEmail, Constants.BadAccountPassword)]
        [TestCase(Constants.BadAccountEmail, Constants.GoodAccountPassword)]
        [TestCase(Constants.BadAccountEmail, Constants.BadAccountPassword)]
        public void LoginNegative(string email, string pass)
        {
            Pages.Header.GoToLogIn();

            Pages.LoginPage.LogIn(email, pass);

            Pages.LoginPage.VerifyErrorMessage().Should().BeTrue();
        }

        [Test]
        public void RegisterTest()
        {
            Pages.Header.GoToRegister();

            Pages.RegisterPage.FillInRegisterForm();

            Pages.RegisterPage.ClickOnRegister();

            Pages.AccountPage.VerifyRegisterMessage(Constants.RegisterSuccesssMessage).Should().BeTrue();
        } 
    }
}

