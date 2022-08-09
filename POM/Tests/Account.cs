using POM.Helpers;
using NUnit.Framework;
using FluentAssertions;

namespace POM.Tests
{
    [TestFixture]
    public class Account : BaseTest
    {
        [Test]
        [TestCase(Constants.GOODACCOUNTEMAIL,Constants.GOODACCOUNTPASSWORD)]
        [TestCase(Constants.GOODACCOUNTEMAIL, Constants.BADACCOUNTPASSWORD)]
        [TestCase(Constants.BADACCOUNTEMAIL, Constants.GOODACCOUNTPASSWORD)]
        [TestCase(Constants.BADACCOUNTEMAIL, Constants.BADACCOUNTPASSWORD)]
        public void Login(string email, string pass)
        {
            Pages.Header.GoToLogIn();

            Pages.LoginPage.LogIn(email, pass);

            Pages.AccountPage.VerifyHelloMessage(Constants.ASDACCOUNTHELLOMESSAGE).Should().BeTrue();
        }
    }
}
