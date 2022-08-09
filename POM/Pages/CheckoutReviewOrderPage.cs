using OpenQA.Selenium;
using System.Linq;
using POM.Helpers;
using OpenQA.Selenium.Support.UI;

namespace POM.Pages
{
    public class CheckoutReviewOrderPage
    {
        #region Selectors

        private readonly By _place_order_button = By.CssSelector(".button.btn-checkout");
        private readonly By _order_placed_successfully = By.CssSelector(".page-title h1");

        #endregion

        public void ClickOnPlaceOrder()
        {
            WaitHelper.WaitUntilElementVisible(_place_order_button);
            Driver.WebDriver.FindElement(_place_order_button).Click();
        }

        public bool OrderSuccess()
        {
            return Driver.WebDriver.FindElement(_order_placed_successfully).Displayed;
        }

    }
}
