using OpenQA.Selenium;
using POM.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace POM.Pages
{
    public class ProductCategoryPage
    {
        #region Selectors

        private readonly By _productList = By.CssSelector(".category-products > ul > li");
        private readonly By _colorList = By.CssSelector(".configurable-swatch-list.configurable-swatch-color.clearfix");

        #endregion

        public void SelectProduct(int productIndex)
        {
            Driver.WebDriver.FindElements(_productList).ToArray()[productIndex].Click();
        }

        public void SelectFromProductList()
        {
            var productList = Driver.WebDriver.FindElements(_productList);

            List<IWebElement> productsWithColorOptionList = new List<IWebElement>();

            foreach (var productItem in productList)
            {
                try
                {
                    productItem.FindElement(_colorList);
                    productsWithColorOptionList.Add(productItem);
                }
                catch (Exception)
                {
                    Console.WriteLine("Products without color option");
                }
            }
            productsWithColorOptionList[0].Click();
        }
    }
}