using OpenQA.Selenium;
using POM.Helpers;

namespace POM.Pages
{
    public class HomePage
    {
        #region Seletors

        private readonly By _logo = By.CssSelector(".logo");
        private readonly By _category_woman = By.CssSelector(".level0.nav-1.first.parent>.level0.has-children");
        private readonly By _search = By.CssSelector("#search");
        private readonly By _search_button = By.CssSelector(".button.search-button");


        #endregion

        public void ClickLogo()
        {
            Driver.WebDriver.FindElement(_logo).Click();
            WaitHelpers.WaitUntilDocumentReady();
        }

        public void ClickOnWomenCategory()
        {
            Driver.WebDriver.FindElement(_category_woman).Click();
            WaitHelpers.WaitUntilDocumentReady();
        }

        public void Search()
        {
            Driver.WebDriver.FindElement(_search).SendKeys("Chelsea Tee");
            Driver.WebDriver.FindElement(_search_button).Click();
        }
    }
}
