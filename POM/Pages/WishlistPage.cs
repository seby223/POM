using OpenQA.Selenium;
using POM.Helpers;

namespace POM.Pages
{
    public class WishlistPage
    {
        #region Selectors

        private readonly By _productWishlist = By.CssSelector("#wishlist-table tbody tr");

        private readonly By _addToCart = By.CssSelector(".button.btn-cart");

        private readonly By _addAllToCart = By.CssSelector(".buttons-set .buttons-set2 .button.btn-add");

        #endregion

        public void ClickOnAddToCart()
        {
            Driver.WebDriver.FindElement(_productWishlist).FindElement(_addToCart).Click();
        }
        public void ClickOnAddAllToCart()  
        {
            Driver.WebDriver.FindElement(_addAllToCart).Click();
        }

    }
}
