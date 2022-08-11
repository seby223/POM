using NsTestFrameworkUI.Pages;
using OpenQA.Selenium;
using POM.Helpers;

namespace POM.Pages
{
    public class WishlistPage
    {
        #region Selectors

        private readonly By _productWishlist = By.CssSelector("#wishlist-table tbody tr");

        private readonly By _addToCart = By.CssSelector(".cart-cell .btn-cart");

        #endregion

        public void ClickOnAddToCart()
        {
            Driver.WebDriver.FindElement(_productWishlist).FindElement(_addToCart).Click();
        }
    }
}
