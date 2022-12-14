using OpenQA.Selenium;
using System.Linq;
using POM.Helpers;
using OpenQA.Selenium.Support.UI;

namespace POM.Pages
{
    public class CheckoutBillingPage
    {
        #region Selectors

        private readonly By _firstNameText = By.CssSelector("#billing\\:firstname");
        private readonly By _lastNameText = By.CssSelector("#billing\\:lastname");
        private readonly By _emailText = By.CssSelector("[id=\"billing:email\"]");
        private readonly By _addressText = By.CssSelector("[id=\"billing:street1\"]");
        private readonly By _cityText = By.CssSelector("[id=\"billing:city\"]");
        private readonly By _stateSelect = By.CssSelector("[id=\"billing:region_id\"]");
        private readonly By _stateText = By.CssSelector("[id=\"billing:region\"]");
        private readonly By _postcodeText = By.CssSelector("[id=\"billing:postcode\"]");
        private readonly By _countrySelect = By.CssSelector("[id=\"billing:country_id\"]");
        private readonly By _telephoneText = By.CssSelector("[id=\"billing:telephone\"]");
        private readonly By _sameAddressRadioList = By.CssSelector("[name=\"billing[use_for_shipping]\"]");
        private readonly By _continueButton = By.CssSelector("#billing-buttons-container .button");

        #endregion

        public void SelectSameShippingAddress(bool a)
        {
            if (a)
                Driver.WebDriver.FindElements(_sameAddressRadioList).First().Click();
            else
                Driver.WebDriver.FindElements(_sameAddressRadioList).Last().Click();
        }

        public void FillFirstName(string first)
        {
            Driver.WebDriver.FindElement(_firstNameText).SendKeys(first);

        }

        public void FillLastName(string last)
        {
            Driver.WebDriver.FindElement(_lastNameText).SendKeys(last);
        }

        public void FillEmail(string email)
        {
            Driver.WebDriver.FindElement(_emailText).SendKeys(email);
        }

        public void FillAddress(string address)
        {
            Driver.WebDriver.FindElement(_addressText).SendKeys(address);
        }

        public void FillCity(string city)
        {
            Driver.WebDriver.FindElement(_cityText).SendKeys(city);
        }

        private bool IsStateSelectDisplayed()
        {
            return Driver.WebDriver.FindElement(_stateSelect).Displayed;
        }

        public void FillCountry(string country)
        {
            new SelectElement(Driver.WebDriver.FindElement(_countrySelect)).SelectByValue(country);

        }

        public void FillState(string state)
        {

            if (IsStateSelectDisplayed() == true)
                new SelectElement(Driver.WebDriver.FindElement(_stateSelect)).SelectByValue(state);
            else
                Driver.WebDriver.FindElement(_stateText).SendKeys(state);
        }

        public void FillZip(string postcode)
        {
            Driver.WebDriver.FindElement(_postcodeText).SendKeys(postcode);
        }

        public void FillPhone(string telephone)
        {
            Driver.WebDriver.FindElement(_telephoneText).SendKeys(telephone);
        }

        public void ClickOnContinue()
        {
            Driver.WebDriver.FindElement(_continueButton).Click();
        }

        public void FillOutForm(CheckoutInfo checkoutInfo)
        {
            WaitHelper.WaitUntilElementVisible(_continueButton);
            FillFirstName(checkoutInfo.FirstName);
            FillLastName(checkoutInfo.LastName);
            FillEmail(checkoutInfo.Email);
            FillAddress(checkoutInfo.Address1);
            FillCity(checkoutInfo.City);
            FillCountry(checkoutInfo.Country);
            FillState(checkoutInfo.State);
            FillZip(checkoutInfo.Zip);
            FillPhone(checkoutInfo.Phone);
            SelectSameShippingAddress(true);
            ClickOnContinue();
        }
    }
}
