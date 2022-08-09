using OpenQA.Selenium;
using System.Linq;
using POM.Helpers;

namespace POM.Pages
{
    public class AccountPage
    {
        #region Selectors

        private readonly By _hello_message = By.CssSelector(".hello strong");
        private readonly By _register_success_message = By.CssSelector(".success-msg");

        #endregion
        public bool VerifyHelloMessage(string message)
        {
            //WaitHelpers.WaitUntilElementVisible(_hello_message);
            return Driver.WebDriver.FindElement(_hello_message).Text.Equals(message);
        }

        public bool VerifyRegisterMessage(string message)
        {
            return Driver.WebDriver.FindElement(_register_success_message).Text.Equals(message);
        }
    }
}
