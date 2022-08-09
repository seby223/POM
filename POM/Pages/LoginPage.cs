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

        #endregion

        public void LogIn(string email, string password)
        {
            WaitHelpers.WaitUntilElementVisible(_login_button);
            Driver.WebDriver.FindElement(_email_text).SendKeys(email);
            Driver.WebDriver.FindElement(_password_text).SendKeys(password);
            Driver.WebDriver.FindElement(_login_button).Click();
        }
    }
}
