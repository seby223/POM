using OpenQA.Selenium;
using POM.Helpers;

namespace POM.Pages
{
    public class CheckoutPage
    {
        #region Selectors

        private readonly By _guestOption = By.CssSelector("[id=\"login:guest\"]");
        private readonly By _continueButton = By.CssSelector("#onepage-guest-register-button");

        #endregion

        public void CheckoutAsGuest()
        {
            Driver.WebDriver.FindElement(_guestOption).Click();
        }

        public void ClickContinueButton()
        {
            Driver.WebDriver.FindElement(_continueButton).Click();
        }


    }
}
