using OpenQA.Selenium;
using System.Linq;
using POM.Helpers;
using OpenQA.Selenium.Support.UI;

namespace POM.Pages
{
    public class CheckoutBillingPage
    {
        #region Selectors

        private readonly By _first_name_text = By.CssSelector("#billing\\:firstname");
        private readonly By _middle_name_text = By.CssSelector("#billing\\:middlename");
        private readonly By _last_name_text = By.CssSelector("#billing\\:lastname");
        private readonly By _company_text = By.CssSelector("[id=\"billing:company\"]");
        private readonly By _email_text = By.CssSelector("[id=\"billing:email\"]");
        private readonly By _address_1_text = By.CssSelector("[id=\"billing:street1\"]");
        private readonly By _address_2_text = By.CssSelector("[id=\"billing:street2\"]");
        private readonly By _city_text = By.CssSelector("[id=\"billing:city\"]");
        private readonly By _state_select = By.CssSelector("[id=\"billing:region_id\"]");
        private readonly By _state_text = By.CssSelector("[id=\"billing:region\"]");
        private readonly By _postcode_text = By.CssSelector("[id=\"billing:postcode\"]");
        private readonly By _country_select = By.CssSelector("[id=\"billing:country_id\"]");
        private readonly By _telephone_text = By.CssSelector("[id=\"billing:telephone\"]");
        private readonly By _fax_text = By.CssSelector("[id=\"billing:fax\"]");
        private readonly By _same_address_radio_list = By.CssSelector("[name=\"billing[use_for_shipping]\"]");
        private readonly By _continue_button = By.CssSelector("#billing-buttons-container .button");

        #endregion

        public void SelectShippingAddress(bool a)
        {
            if (a)
                Driver.WebDriver.FindElements(_same_address_radio_list).First().Click();
            else
                Driver.WebDriver.FindElements(_same_address_radio_list).Last().Click();
        }

        public void FillNames(string first, string last)
        {
            Driver.WebDriver.FindElement(_first_name_text).SendKeys(first);
            //Driver.WebDriver.FindElement(_billing_middle_name_text).SendKeys(middle);
            Driver.WebDriver.FindElement(_last_name_text).SendKeys(last);
        }

        public void FillAddress(string email, string address, string city)
        {
            Driver.WebDriver.FindElement(_email_text).SendKeys(email);
            Driver.WebDriver.FindElement(_address_1_text).SendKeys(address);
            Driver.WebDriver.FindElement(_city_text).SendKeys(city);
        }

        private bool IsStateSelectDisplayed()
        {
            return Driver.WebDriver.FindElement(_state_select).Displayed;
        }

        public void FillCountryandState(string country, string state)
        {
            new SelectElement(Driver.WebDriver.FindElement(_country_select)).SelectByValue(country);
            if (IsStateSelectDisplayed() == true)
                new SelectElement(Driver.WebDriver.FindElement(_state_select)).SelectByValue(state);
            else
                Driver.WebDriver.FindElement(_state_text).SendKeys(state);
        }

        public void FillZipPhone(string postcode, string telephone)
        {
            Driver.WebDriver.FindElement(_postcode_text).SendKeys(postcode);
            Driver.WebDriver.FindElement(_telephone_text).SendKeys(telephone);
        }

        public void ClickOnContinue()
        {
            Driver.WebDriver.FindElement(_continue_button).Click();
        }

        public void FillOutForm()
        {
            WaitHelper.WaitUntilElementVisible(_continue_button);
            FillNames("first", "last");
            FillAddress("asd@yahoo.com", "asd home", "asd city");
            FillCountryandState("US", "3");
            FillZipPhone("123123", "1231231231");
            SelectShippingAddress(true);
            ClickOnContinue();
        }
    }
}
