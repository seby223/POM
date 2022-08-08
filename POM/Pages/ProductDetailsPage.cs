using OpenQA.Selenium;
using System.Linq;
using POM.Helpers;

namespace POM.Pages
{
    public class ProductDetailsPage : Header
    {
        #region Selectors

        private readonly By _addToCartButton = By.CssSelector(".add-to-cart-buttons .button.btn-cart");

        #endregion

        public bool IsAddToCartButtonDisplayed()
        {
            return Driver.WebDriver.FindElement(_addToCartButton).Displayed;
        }
    }
}
