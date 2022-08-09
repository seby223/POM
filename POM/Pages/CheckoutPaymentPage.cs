using OpenQA.Selenium;
using System.Linq;
using POM.Helpers;
using OpenQA.Selenium.Support.UI;

namespace POM.Pages
{
    public class CheckoutPaymentPage
    {
        #region Selectors

        private readonly By _continue_button = By.CssSelector("#payment-buttons-container .button");

        #endregion

        public void PaymentClickOnContinue()
        {
            WaitHelper.WaitUntilElementVisible(_continue_button);
            Driver.WebDriver.FindElement(_continue_button).Click();
        }
    }
}
