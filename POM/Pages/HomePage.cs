using OpenQA.Selenium;
using System.Linq;
using POM.Helpers;

namespace POM.Pages
{
    public class HomePage
    {

        public readonly string Url = "http://qa2magento.dev.evozon.com/";

        #region Seletors
        
        private readonly By _new_products = By.CssSelector(".widget-products >ul >li");
        private readonly By _slideshow = By.CssSelector(".slideshow li:first-child");
        private readonly By _promos = By.CssSelector(".promos li");

        #endregion

        public void ClickOnNewProduct(int i)
        {
            Driver.WebDriver.FindElements(_new_products).ToArray()[i].Click();
        }

        public void ClickOnPromos(int i)
        {
            Driver.WebDriver.FindElements(_promos).ToArray()[i].Click();
        }

        public void ClickOnSlide()
        {
            Driver.WebDriver.FindElement(_slideshow).Click();
        }

        public int CountNewProducts()
        {
            return Driver.WebDriver.FindElements(_new_products).Count();
        }



    }
}
