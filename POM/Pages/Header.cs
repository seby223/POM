using OpenQA.Selenium;
using System.Linq;
using POM.Helpers;

namespace POM.Pages
{
    public class Header
    {
        #region Selectors

        private readonly By _welcome_msg = By.CssSelector(".welcome-msg");
        private readonly By _account = By.CssSelector(".skip-link.skip-account");
        private readonly By _account_links_list = By.CssSelector("#header-account .links li");
        private readonly By _category_list = By.CssSelector(".nav-primary > li");
        private readonly By _search_field = By.CssSelector("#search");
        private readonly By _search_button = By.CssSelector(".button.search-button");
        private readonly By _logo = By.CssSelector(".logo");
        private readonly By _language_list = By.CssSelector("#select-language");
        private readonly By _minicart = By.CssSelector(".header-minicart");
        private readonly By _minicart_products_list = By.CssSelector(".mini-products-list");
        private readonly By _minicart_subtotal = By.CssSelector(".subtotal .price");
        private readonly By _minicart_add_button = By.CssSelector(".button.checkout-button");
        private readonly By _minicart_cart_button = By.CssSelector(".cart-link");

        #endregion

        public void ClickLogo()
        {
            Driver.WebDriver.FindElement(_logo).Click();
            WaitHelpers.WaitUntilDocumentReady();
        }

        public void ClickOnWomenCategory()
        {
            Driver.WebDriver.FindElements(_category_list).ToArray()[1].Click();
            WaitHelpers.WaitUntilDocumentReady();
        }

        public void Search(string SearchString)
        {
            Driver.WebDriver.FindElement(_search_field).SendKeys(SearchString);
            Driver.WebDriver.FindElement(_search_button).Click();
        }
    }
}
