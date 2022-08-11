using OpenQA.Selenium;
using POM.Helpers;

namespace POM.Pages
{
    public class AccountPage
    {
        #region Selectors

        private readonly By _helloMessage = By.CssSelector(".hello strong");
        private readonly By _registerSuccessMessage = By.CssSelector(".success-msg");

        #endregion
        public bool VerifyHelloMessage(string message)
        {

            return Driver.WebDriver.FindElement(_helloMessage).Text.Equals(message);
        }

        public bool VerifyRegisterMessage(string message)
        {
            return Driver.WebDriver.FindElement(_registerSuccessMessage).Text.Equals(message);
        }
    }
}
