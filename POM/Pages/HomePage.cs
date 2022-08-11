using OpenQA.Selenium;
using System.Linq;
using POM.Helpers;

namespace POM.Pages
{
    public class HomePage
    {

        #region Seletors
        
        private readonly By _newProducts = By.CssSelector(".widget-products >ul >li");
        private readonly By _slideshow = By.CssSelector(".slideshow li:first-child");
        private readonly By _promos = By.CssSelector(".promos li");

        #endregion

        public void ClickOnNewProduct(int i)
        {
            Driver.WebDriver.FindElements(_newProducts).ToArray()[i].Click();
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
            return Driver.WebDriver.FindElements(_newProducts).Count();
        }



    }
}
