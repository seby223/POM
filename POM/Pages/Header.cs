using OpenQA.Selenium;
using System.Linq;
using POM.Helpers;
using OpenQA.Selenium.Interactions;

namespace POM.Pages
{
    public class Header
    {
        #region Selectors

        private readonly By _account = By.CssSelector(".skip-link.skip-account");
        private readonly By _accountLinksList = By.CssSelector("#header-account .links li");
        private readonly By _categoryList = By.CssSelector(".nav-primary > li");
        private readonly By _searchField = By.CssSelector("#search");
        private readonly By _searchButton = By.CssSelector(".button.search-button");
        private readonly By _logo = By.CssSelector(".logo");
        private readonly By _minicartCount = By.CssSelector(".count");
        private readonly By _subcategoryList = By.CssSelector("li.level1");

        #endregion

        public void ClickLogo()
        {
            Driver.WebDriver.FindElement(_logo).Click();
        }

        public void ClickOnWomenCategory()
        {
            Driver.WebDriver.FindElements(_categoryList).ToArray()[1].Click();
        }

        public void Search(string SearchString)
        {
            Driver.WebDriver.FindElement(_searchField).SendKeys(SearchString);
            Driver.WebDriver.FindElement(_searchButton).Click();
        }
        public void GoToLogIn()
        {
            Driver.WebDriver.FindElement(_account).Click();
            Driver.WebDriver.FindElements(_accountLinksList).Last().Click();
        }

        public void GoToRegister()
        {
            Driver.WebDriver.FindElement(_account).Click();
            IWebElement[] x = Driver.WebDriver.FindElements(_accountLinksList).ToArray();
            x[x.Length - 2].Click();
        }


        public string GetProductCount()
        {
            return Driver.WebDriver.FindElement(_minicartCount).Text;
        }

        public void SelectSubcategory(int categoryIndex, int subcategoryIndex)
        {
            var actions = new Actions(Driver.WebDriver);
            var categoryList = Driver.WebDriver.FindElements(_categoryList).ToArray()[categoryIndex];

            actions.MoveToElement(categoryList);
            actions.MoveToElement(categoryList.FindElements(_subcategoryList).ToArray()[subcategoryIndex]);
            actions.Click().Build().Perform();
        }
    }
}
