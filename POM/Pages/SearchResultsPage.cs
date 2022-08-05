using OpenQA.Selenium;
using System.Linq;
using POM.Helpers;

namespace POM.Pages
{
    public class SearchResultsPage
    {
        #region Selectors

        private readonly By _productNameList = By.CssSelector("li.item.last");

        #endregion

        public void GoToDetailsPage()
        {
            Driver.WebDriver.FindElements(_productNameList).First().Click();
        }
            
    }
}
