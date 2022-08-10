using OpenQA.Selenium;
using System.Linq;
using POM.Helpers;
using OpenQA.Selenium.Support.UI;

namespace POM.Pages
{
    public class CheckoutPage
    {
        #region Selectors

        private readonly By _guest_option = By.CssSelector("[id=\"login:guest\"]");
        private readonly By _guest_continue_button = By.CssSelector("#onepage-guest-register-button");
        
        #endregion

        public void SelectGuestOption()
        {
            Driver.WebDriver.FindElement(_guest_option).Click();
            Driver.WebDriver.FindElement(_guest_continue_button).Click();
        }

       
    }
}
