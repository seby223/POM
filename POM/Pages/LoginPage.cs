using OpenQA.Selenium;
using System.Linq;
using POM.Helpers;

namespace POM.Pages
{
    public class LoginPage
    {
        #region Selectors

        private readonly By _email_text = By.CssSelector("#email");
        private readonly By _password_text = By.CssSelector("#pass");
        private readonly By _login_button = By.CssSelector("#send2");
        private readonly By _error_message = By.CssSelector(".error-msg span");

        #endregion

        public void LogIn(string email, string password)
        {
            WaitHelper.WaitUntilElementVisible(_login_button);
            Driver.WebDriver.FindElement(_email_text).SendKeys(email);
            Driver.WebDriver.FindElement(_password_text).SendKeys(password);
            Driver.WebDriver.FindElement(_login_button).Click();
        }

        public bool VerifyErrorMessage()
        {
            return Driver.WebDriver.FindElement(_error_message).Displayed;
        }
    }
}
