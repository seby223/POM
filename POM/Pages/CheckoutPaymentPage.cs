using OpenQA.Selenium;
using POM.Helpers;

namespace POM.Pages
{
    public class CheckoutPaymentPage
    {
        #region Selectors

        private readonly By _continueButton = By.CssSelector("#payment-buttons-container .button");

        #endregion

        public void PaymentClickOnContinue()
        {
            WaitHelper.WaitUntilElementVisible(_continueButton);
            Driver.WebDriver.FindElement(_continueButton).Click();
        }
    }
}
