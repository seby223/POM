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
        [Test]
        public void RegisterWithoutMail()
        {
            Pages.Header.GoToRegister();
            Pages.RegisterPage.FillFirstName(Faker.Name.First());
            Pages.RegisterPage.FillLastName(Faker.Name.Last());
            Pages.RegisterPage.FillPassword(Constants.GoodAccountPassword);
            Pages.RegisterPage.FillConfirmPassword(Constants.GoodAccountPassword);
            Pages.RegisterPage.ClickOnRegister();
            Pages.RegisterPage.VerifyErrorMessage("\"Email\" is a required value.").Should().BeTrue();
        }

        [Test]
        public void RegisterWithExistingEmail()
        {
            Pages.Header.GoToRegister();
            Pages.RegisterPage.FillFirstName(Faker.Name.First());
            Pages.RegisterPage.FillLastName(Faker.Name.Last());
            Pages.RegisterPage.FillEmail(Constants.GoodAccountEmail);
            Pages.RegisterPage.FillPassword(Constants.GoodAccountPassword);
            Pages.RegisterPage.FillConfirmPassword(Constants.GoodAccountPassword);
            Pages.RegisterPage.ClickOnRegister();
            Pages.RegisterPage.VerifyErrorMessage("There is already an account with this email address. " +
                "If you are sure that it is your email address, click here to get your password and access" +
                " your account.").Should().BeTrue();
            Pages.RegisterPage.ClickExistingAccountErrorButton();
            Pages.RegisterPage.VerifyForgotPassword().Should().BeTrue();
        }
    }
}

