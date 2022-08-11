using OpenQA.Selenium;
using POM.Helpers;
using OpenQA.Selenium.Support.UI;

namespace POM.Pages
{
    public class CheckoutShippingPage
    {
        #region Selectors

        private readonly By _editButton = By.CssSelector("#opc-shipping .step-title");
        private readonly By _editLink = By.CssSelector("#opc-shipping .step-title a");
        private readonly By _firstNameText = By.CssSelector("[id=\"shipping:firstname\"]");
        private readonly By _lastNameText = By.CssSelector("[id=\"shipping:lastname\"]");
        private readonly By _addressText = By.CssSelector("[id=\"shipping:street1\"]");
        private readonly By _cityText = By.CssSelector("[id=\"shipping:city\"]");
        private readonly By _stateSelect = By.CssSelector("[id=\"shipping:region_id\"]");
        private readonly By _stateText = By.CssSelector("[id=\"shipping:region\"]");
        private readonly By _postcodeText = By.CssSelector("[id=\"shipping:postcode\"]");
        private readonly By _countrySelect = By.CssSelector("[id=\"shipping:country_id\"]");
        private readonly By _telephoneText = By.CssSelector("[id=\"shipping:telephone\"]");
        private readonly By _continueButton = By.CssSelector("#shipping-buttons-container .button");

        #endregion

        public void ClickOnEdit()
        {
            Driver.WebDriver.FindElement(_editButton).Click();
        }

        public void ClickOnContinue()
        {
            Driver.WebDriver.FindElement(_continueButton).Click();
        }

        public void FillFirstName(string first)
        {
            Driver.WebDriver.FindElement(_firstNameText).SendKeys(first);
        }

        public void FillLastName(string last)
        {
            Driver.WebDriver.FindElement(_lastNameText).SendKeys(last);
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

            if (IsStateSelectDisplayed())
                new SelectElement(Driver.WebDriver.FindElement(_stateSelect)).SelectByValue(state);
            else
                Driver.WebDriver.FindElement(_stateText).SendKeys(state);
        }

        public void FillZip(string postalcode)
        {
            Driver.WebDriver.FindElement(_postcodeText).SendKeys(postalcode);

        }

        public void FillPhone(string telephone)
        {

            Driver.WebDriver.FindElement(_telephoneText).SendKeys(telephone);
        }

        public void FillOutForm()
        {
            WaitHelper.WaitUntilElementVisible(_editLink);
            ClickOnEdit();
            FillFirstName(Faker.Name.First());
            FillLastName(Faker.Name.Last());
            FillAddress(Faker.Address.StreetAddress());
            FillCity(Faker.Address.City());
            FillCountry("US");
            FillState("3");
            FillZip(Faker.RandomNumber.Next().ToString());
            FillPhone(Faker.RandomNumber.Next().ToString());
            ClickOnContinue();
        }

        public void SameAddressClientContinue()
        {
            WaitHelper.WaitUntilElementVisible(_edit_link);
            ClickOnEdit();
            ClickOnContinue();
        }
    }
}
