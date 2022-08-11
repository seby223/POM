using OpenQA.Selenium;
using POM.Data;
using POM.Helpers;

namespace POM.Pages
{
    public class CheckoutShipMethodPage
    {
        #region Selectors

        private readonly By _freeRadio = By.CssSelector("#s_method_freeshipping_freeshipping");
        private readonly By _flatRadio = By.CssSelector("#s_method_flatrate_flatrate");
        private readonly By _continueButton = By.CssSelector("#shipping-method-buttons-container .button");

        #endregion

        public void SelectShippingMethod(string radio)
        {
            if (radio.Equals("free"))
                Driver.WebDriver.FindElement(_freeRadio).Click();
            else
                Driver.WebDriver.FindElement(_flatRadio).Click();
        }

        public void ClickOnContinue()
        {
            Driver.WebDriver.FindElement(_continueButton).Click();
        }

        public void FillOutForm(CheckoutInfo checkoutInfo)
        {
            WaitHelper.WaitUntilElementVisible(_continueButton);
            SelectShippingMethod(checkoutInfo.ShippingMethod);
            ClickOnContinue();
        }
    }
}
