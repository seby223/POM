using OpenQA.Selenium;
using POM.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POM.Pages
{
    public class WishlistPage
    {
        #region Selectors

        private readonly By _productWishlist = By.CssSelector("#wishlist-table tbody tr");

        private readonly By _addToCart = By.CssSelector(".cart-cell .button.btn-cart");

        #endregion

        public void AddToCart()
        {
            Driver.WebDriver.FindElement(_addToCart).Click();
        }

    }
}
