using NsTestFrameworkUI.Helpers;
using NsTestFrameworkUI.Pages;
using OpenQA.Selenium;
using POM.Helpers;
using System.Threading;

namespace POM.Pages
{
    public class WishlistPage
    {
        #region Selectors

        private readonly By _emptyWishlist = By.CssSelector(".fieldset");

        private readonly By _productWishlist = By.CssSelector("#wishlist-table tbody tr");

        private readonly By _addToCart = By.CssSelector(".cart-cell .btn-cart");

        private readonly By _deleteProduct = By.CssSelector(".btn-remove.btn-remove2");


        #endregion
        public bool VerifyEmptyWishlist()
        {
            return Driver.WebDriver.FindElement(_emptyWishlist).Displayed;
        }

        public void ClickOnAddToCart()
        {
            Driver.WebDriver.FindElement(_productWishlist).FindElement(_addToCart).Click();
        }

        public void ClearWishlist()
        {
           var delete =  Driver.WebDriver.FindElement(_deleteProduct);

            delete.Click();

            var alertMessage = Driver.WebDriver.SwitchTo().Alert();
            alertMessage.Accept();

            WaitHelper.WaitUntilElementVisible(_emptyWishlist);
        }
    }
}
