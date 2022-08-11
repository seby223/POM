using OpenQA.Selenium;
using POM.Helpers;

namespace POM.Pages
{
    public class CheckoutReviewOrderPage
    {
        #region Selectors

        private readonly By _placeOrderButton = By.CssSelector(".button.btn-checkout");
        private readonly By _orderPlacedSuccessfully = By.CssSelector(".page-title h1");

        #endregion

        public void ClickOnPlaceOrder()
        {
            WaitHelper.WaitUntilElementVisible(_placeOrderButton);
            Driver.WebDriver.FindElement(_placeOrderButton).Click();
        }

        public bool OrderSuccess()
        {
            return Driver.WebDriver.FindElement(_orderPlacedSuccessfully).Displayed;
        }

    }
}
