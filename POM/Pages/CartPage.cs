using OpenQA.Selenium;
using POM.Helpers;

namespace POM.Pages
{
    public class CartPage
    {
        #region Selectors

        private readonly By _checkoutButton = By.CssSelector(".checkout-types.bottom .button");

        private readonly By _shoppingCartProductList = By.CssSelector("#shopping-cart-table tbody > tr");

        #endregion

        public void ClickOnCheckoutButton()
        {
            Driver.WebDriver.FindElement(_checkoutButton).Click();
        }
        public bool VerifyShoppingCartProduct()
        {
            return Driver.WebDriver.FindElement(_shoppingCartProductList).Displayed;
        }

    }
}
