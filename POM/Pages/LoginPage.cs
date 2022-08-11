using OpenQA.Selenium;
using POM.Helpers;

namespace POM.Pages
{
    public class LoginPage
    {
        #region Selectors

        private readonly By _emailText = By.CssSelector("#email");
        private readonly By _passwordText = By.CssSelector("#pass");
        private readonly By _loginButton = By.CssSelector("#send2");
        private readonly By _errorMessage = By.CssSelector(".error-msg span");

        #endregion

        public void LogIn(string email, string password)
        {
            WaitHelper.WaitUntilElementVisible(_loginButton);
            Driver.WebDriver.FindElement(_emailText).SendKeys(email);
            Driver.WebDriver.FindElement(_passwordText).SendKeys(password);
            Driver.WebDriver.FindElement(_loginButton).Click();
        }

        public bool VerifyErrorMessage()
        {
            return Driver.WebDriver.FindElement(_errorMessage).Displayed;
        }
    }
}
