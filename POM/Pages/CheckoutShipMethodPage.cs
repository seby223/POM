using OpenQA.Selenium;
using System.Linq;
using POM.Helpers;
using OpenQA.Selenium.Support.UI;

namespace POM.Pages
{
    public class CheckoutShipMethodPage
    {
        #region Selectors

        private readonly By _free_radio = By.CssSelector("#s_method_freeshipping_freeshipping");
        private readonly By _flat_radio = By.CssSelector("#s_method_flatrate_flatrate");
        private readonly By _continue_button = By.CssSelector("#shipping-method-buttons-container .button");

        #endregion

        public void SelectShippingMethod(string s)
        {
            if (s.Equals("free"))
                Driver.WebDriver.FindElement(_free_radio).Click();
            else
                Driver.WebDriver.FindElement(_flat_radio).Click();
        }

        public void ClickOnContinue()
        {
            Driver.WebDriver.FindElement(_continue_button).Click();
        }

        public void FillOutForm()
        {
            WaitHelper.WaitUntilElementVisible(_continue_button);
            SelectShippingMethod("free");
            ClickOnContinue();
        }
    }
}
