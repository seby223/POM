using OpenQA.Selenium;
using System.Linq;
using POM.Helpers;

namespace POM.Pages
{
    public class SearchResultsPage
    {
        #region Selectors

        private readonly By _productNameList = By.CssSelector(".category-products .item.last > a > img");

        #endregion

        public void GoToDetailsPageOfFirstItem()
        {
            Driver.WebDriver.FindElements(_productNameList).First().Click();
        }
            
    }
}
