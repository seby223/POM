using OpenQA.Selenium;
using System.Linq;
using POM.Helpers;
using System.Collections.Generic;
using System;
using NUnit.Framework;

namespace POM.Pages
{
    public class SearchResultsPage
    {
        #region Selectors

        private readonly By _productNameList = By.CssSelector("li.item.last");
        private readonly By _productName = By.CssSelector("div.category-products > ul > li:nth-child(3) > a");
        private readonly By _dreesList = By.CssSelector("div.category-products > ul > li");
        private readonly By _dressName = By.CssSelector("div.product-info > h2 > a");

        #endregion

        public void GoToDetailsPageOfFirstItem()
        {
            Driver.WebDriver.FindElements(_productNameList).First().Click();
        }

        public bool IsProductNameFirstProduct()
        {
            var element = Driver.WebDriver.FindElement(_productName);
            return element.Displayed;
        }

        public void SelectFromDressList()
        {
            var productList = Driver.WebDriver.FindElements(_dreesList);

            var notDress = productList.FirstOrDefault(product =>
            {
                string dressName = product.FindElement(_dressName).Text;
                return !dressName.Contains("DRESS");
            });

            Assert.IsNull(notDress);
        }
    }
}
