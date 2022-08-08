using OpenQA.Selenium;
using System.Linq;
using POM.Helpers;

namespace POM.Pages
{
    public class CartPage : Header
    {
        #region Selectors

        private readonly By _checkout_button = By.CssSelector(".checkout-types.bottom .button");

        #endregion

        public void ClickOnCheckoutButton()
        {
            Driver.WebDriver.FindElement(_checkout_button).Click();
        }
    }
}
