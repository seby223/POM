using OpenQA.Selenium;
using POM.Helpers;

namespace POM.Pages
{
    public class RegisterPage
    {
        #region Selectors
        private readonly By _firstNameField = By.CssSelector("#firstname");
        private readonly By _middleNameField = By.CssSelector("#middlename");
        private readonly By _lastNameField = By.CssSelector("#lastname");
        private readonly By _emailField = By.CssSelector("#email_address");
        private readonly By _passwordField = By.CssSelector("#password");
        private readonly By _confirmPasswordField = By.CssSelector("#confirmation");
        private readonly By _registerButton = By.CssSelector(".buttons-set .button");
        private readonly By _existingAccountErrorButton = By.CssSelector(".error-msg a");
        private readonly By _errorMessage = By.CssSelector(".error-msg");
        private readonly By _forgotPassword = By.CssSelector(".page-title h1");
        #endregion

        public void FillFirstName(string first)
        {
            var firstName = Driver.WebDriver.FindElement(_firstNameField);
            firstName.Clear();
            firstName.SendKeys(first);

        }

        public void FillMiddleName(string middle)
        {

            var middleName = Driver.WebDriver.FindElement(_middleNameField);
            middleName.Clear();
            middleName.SendKeys(middle);
        }

        public void FillLastName(string last)
        {

            var lastName = Driver.WebDriver.FindElement(_lastNameField);
            lastName.Clear();
            lastName.SendKeys(last);
        }

        public void FillEmail(string email)
        {
            var mail = Driver.WebDriver.FindElement(_emailField);
            mail.Clear();
            mail.SendKeys(email);
        }

        public void FillPassword(string password)
        {
            var pass = Driver.WebDriver.FindElement(_passwordField);
            pass.Clear();
            pass.SendKeys(password);

        }

        public void FillConfirmPassword(string password)
        {

            var pass = Driver.WebDriver.FindElement(_confirmPasswordField);
            pass.Clear();
            pass.SendKeys(password);
        }

        public void ClickOnRegister()
        {
            Driver.WebDriver.FindElement(_registerButton).Click();
        }

        public void ClickExistingAccountErrorButton()
        {
            Driver.WebDriver.FindElement(_existingAccountErrorButton).Click();
        }

        public bool VerifyErrorMessage(string message)
        {

            return Driver.WebDriver.FindElement(_errorMessage).Text.Equals(message);
        }

        public bool VerifyForgotPassword()
        {

            return Driver.WebDriver.FindElement(_forgotPassword).Displayed;
        }

        public void FillInRegisterForm()
        {
            FillFirstName(Faker.Name.First());
            FillMiddleName(Faker.Name.Middle());
            FillLastName(Faker.Name.Last());
            FillEmail(Faker.Name.Last() + "@yahoo.com");
            FillPassword("asdasd");
            FillConfirmPassword("asdasd");
        }
    }
}
