using OpenQA.Selenium;
using System.Linq;
using POM.Helpers;
using OpenQA.Selenium.Interactions;

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
        private readonly By _minicartCount = By.CssSelector(".count");
        private readonly By _topsAndBlouses = By.CssSelector(".level1.nav-1-2");

        #endregion

        public void ClickLogo()
        {
            Driver.WebDriver.FindElement(_logo).Click();
        }

        public void ClickOnWomenCategory()
        {
            Driver.WebDriver.FindElements(_category_list).ToArray()[1].Click();
        }

        public void Search(string SearchString)
        {
            Driver.WebDriver.FindElement(_search_field).SendKeys(SearchString);
            Driver.WebDriver.FindElement(_search_button).Click();
        }
        public void GoToLogIn()
        {
            Driver.WebDriver.FindElement(_account).Click();
            //WaitHelpers.WaitUntilElementVisible(_account_links_list);
            Driver.WebDriver.FindElements(_account_links_list).Last().Click();
        }

        public void GoToRegister()
        {
            Driver.WebDriver.FindElement(_account).Click();
            IWebElement[] x = Driver.WebDriver.FindElements(_account_links_list).ToArray();
            x[x.Length - 2].Click();
        }


        public string GetProductCount()
        {
            return Driver.WebDriver.FindElement(_minicartCount).Text;
        }
        public void SelectSubcategory()
        {
            Actions actions = new Actions(Driver.WebDriver);

            actions.MoveToElement(Driver.WebDriver.FindElement(_category_list));
            actions.MoveToElement(Driver.WebDriver.FindElement(_topsAndBlouses));

            actions.Click().Build().Perform();
        }
    }
}
