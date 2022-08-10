using OpenQA.Selenium;
using System.Linq;
using POM.Helpers;

namespace POM.Pages
{
    public class CartPage
    {
        #region Selectors

        private readonly By _checkout_button = By.CssSelector(".checkout-types.bottom .button");

        private readonly By _shoppingCartProductList = By.CssSelector("#shopping-cart-table tbody > tr");

        #endregion

        public void ClickOnCheckoutButton()
        {
            Driver.WebDriver.FindElement(_checkout_button).Click();
        }
        public bool VerifyShoppingCartProduct()
        {
            return Driver.WebDriver.FindElement(_shoppingCartProductList).Displayed;
        }

    }
}
