using OpenQA.Selenium;
using System.Linq;
using POM.Helpers;
using OpenQA.Selenium.Support.UI;

namespace POM.Pages
{
    public class CheckoutShippingPage
    {
        #region Selectors

        private readonly By _edit_button = By.CssSelector("#opc-shipping .step-title");
        private readonly By _edit_link = By.CssSelector("#opc-shipping .step-title a");
        private readonly By _first_name_text = By.CssSelector("[id=\"shipping:firstname\"]");
        private readonly By _last_name_text = By.CssSelector("[id=\"shipping:lastname\"]");
        private readonly By _address_1_text = By.CssSelector("[id=\"shipping:street1\"]");
        private readonly By _city_text = By.CssSelector("[id=\"shipping:city\"]");
        private readonly By _state_select = By.CssSelector("[id=\"shipping:region_id\"]");
        private readonly By _state_text = By.CssSelector("[id=\"shipping:region\"]");
        private readonly By _postcode_text = By.CssSelector("[id=\"shipping:postcode\"]");
        private readonly By _country_select = By.CssSelector("[id=\"shipping:country_id\"]");
        private readonly By _telephone_text = By.CssSelector("[id=\"shipping:telephone\"]");
        private readonly By _continue_button = By.CssSelector("#shipping-buttons-container .button");

        #endregion

        public void ClickOnEdit()
        {
            Driver.WebDriver.FindElement(_edit_button).Click();
        }

        public void ClickOnContinue()
        {
            Driver.WebDriver.FindElement(_continue_button).Click();
        }

        public void FillNames(string first, string last)
        {
            Driver.WebDriver.FindElement(_first_name_text).SendKeys(first);
            Driver.WebDriver.FindElement(_last_name_text).SendKeys(last);
        }

        public void FillAddress(string address, string city)
        {
            Driver.WebDriver.FindElement(_address_1_text).SendKeys(address);
            Driver.WebDriver.FindElement(_city_text).SendKeys(city);
        }

        private bool IsStateSelectDisplayed()
        {
            return Driver.WebDriver.FindElement(_state_select).Displayed;
        }

        public void FillCountrySate(string country, string state)
        {
            new SelectElement(Driver.WebDriver.FindElement(_country_select)).SelectByValue(country);

            if (IsStateSelectDisplayed())
                new SelectElement(Driver.WebDriver.FindElement(_state_select)).SelectByValue(state);
            else
                Driver.WebDriver.FindElement(_state_text).SendKeys(state);
        }

        public void FillZipPhone(string postalcode, string telephone)
        {
            Driver.WebDriver.FindElement(_postcode_text).SendKeys(postalcode);
            Driver.WebDriver.FindElement(_telephone_text).SendKeys(telephone);
        }

        public void FillOutForm()
        {
            WaitHelper.WaitUntilElementVisible(_edit_link);
            ClickOnEdit();
            FillNames(Faker.Name.First(), Faker.Name.Last());
            FillAddress(Faker.Address.StreetAddress(), Faker.Address.City());
            FillCountrySate("US", "3");
            FillZipPhone(Faker.RandomNumber.Next().ToString(), Faker.RandomNumber.Next().ToString());
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
