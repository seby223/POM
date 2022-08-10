using OpenQA.Selenium;
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

        private readonly By _addToCart = By.CssSelector("");

        #endregion


    }
}
