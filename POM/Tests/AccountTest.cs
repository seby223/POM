using POM.Helpers;
using NUnit.Framework;
using FluentAssertions;

namespace POM.Tests
{
    [TestFixture]
    public class AccountTest : BaseTest
    {
        [Test]
        [TestCase(Constants.GOODACCOUNTEMAIL, Constants.GOODACCOUNTPASSWORD, Constants.ASDACCOUNTHELLOMESSAGE)]
        
        public void LoginPositive(string email, string pass, string message)
        {
            Pages.Header.GoToLogIn();

            Pages.LoginPage.LogIn(email, pass);

            Pages.AccountPage.VerifyHelloMessage(message).Should().BeTrue();
        }

        [Test]
        [TestCase(Constants.GOODACCOUNTEMAIL, Constants.BADACCOUNTPASSWORD)]
        [TestCase(Constants.BADACCOUNTEMAIL, Constants.GOODACCOUNTPASSWORD)]
        [TestCase(Constants.BADACCOUNTEMAIL, Constants.BADACCOUNTPASSWORD)]
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

            Pages.AccountPage.VerifyRegisterMessage(Constants.REGISTERSUCCESSMESSAGE).Should().BeTrue();
        }

       
    }
}
//ceva
