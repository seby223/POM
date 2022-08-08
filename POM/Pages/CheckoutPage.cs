using OpenQA.Selenium;
using System.Linq;
using POM.Helpers;
using OpenQA.Selenium.Support.UI;

namespace POM.Pages
{
    public class CheckoutPage : Header
    {
        #region Selectors

        private readonly By _guest_option = By.CssSelector("[id=\"login:guest\"]");
        private readonly By _guest_continue_button = By.CssSelector("#onepage-guest-register-button");

        private readonly By _billing_first_name_text = By.CssSelector("[id=\"billing:firstname\"]");
        private readonly By _billing_middle_name_text = By.CssSelector("[id=\"billing:middlename\"]");
        private readonly By _billing_last_name_text = By.CssSelector("[id=\"billing:lastname\"]");
        private readonly By _billing_company_text = By.CssSelector("[id=\"billing:company\"]");
        private readonly By _billing_email_text = By.CssSelector("[id=\"billing:email\"]");
        private readonly By _billing_address_1_text = By.CssSelector("[id=\"billing:street1\"]");
        private readonly By _billing_address_2_text = By.CssSelector("[id=\"billing:street2\"]");
        private readonly By _billing_city = By.CssSelector("[id=\"billing:city\"]");
        private readonly By _billing_state_select = By.CssSelector("[id=\"billing:region_id\"]");
        private readonly By _billing_state_text = By.CssSelector("[id=\"billing:region\"]");
        private readonly By _billing_postcode_text = By.CssSelector("[id=\"billing:postcode\"]");
        private readonly By _billing_country_select = By.CssSelector("[id=\"billing:country_id\"]");
        private readonly By _billing_telephone_text = By.CssSelector("[id=\"billimg:telephone\"]");
        private readonly By _billing_fax_text = By.CssSelector("[id=\"billimg:fax\"]");
        private readonly By _billing_same_address_radio_list = By.CssSelector("[name=\"billing[use_for_shipping]\"]");
        private readonly By _billing_continue_button = By.CssSelector(".button.validation-passed");

        private readonly By _shipping_edit_button = By.CssSelector(".step-title>a");


        #endregion

        public void SelectGuestOption()
        {
            Driver.WebDriver.FindElement(_guest_option).Click();
        }

        public void SelectShippingAddress(bool a)
        {
            if(a)
                Driver.WebDriver.FindElements(_billing_same_address_radio_list).First().Click();
            else
                Driver.WebDriver.FindElements(_billing_same_address_radio_list).Last().Click();
        }

        public void FillNames(string first, string middle, string last)
        {
            Driver.WebDriver.FindElement(_billing_first_name_text).SendKeys(first);
            Driver.WebDriver.FindElement(_billing_middle_name_text).SendKeys(middle);
            Driver.WebDriver.FindElement(_billing_last_name_text).SendKeys(last);
        }

        public void FillAddress(string email, string address, string city) 
        {
            Driver.WebDriver.FindElement(_billing_email_text).SendKeys(email);
            Driver.WebDriver.FindElement(_billing_address_1_text).SendKeys(address);
            Driver.WebDriver.FindElement(_billing_address_2_text).SendKeys(city);
        }

        private bool IsStateSelectDisplayed()
        {
            return Driver.WebDriver.FindElement(_billing_state_select).Displayed;
        }

        public void FillCountryandState(string country, string state)
        {
            new SelectElement(Driver.WebDriver.FindElement(_billing_country_select)).SelectByValue(country);
            if (IsStateSelectDisplayed())
                new SelectElement(Driver.WebDriver.FindElement(_billing_state_select)).SelectByValue(state);
            Driver.WebDriver.FindElement(_billing_state_text).SendKeys(state);
        }

        public void FillZipPhone(string postcode, string telephone)
        {
            Driver.WebDriver.FindElement(_billing_postcode_text).SendKeys(postcode);
            Driver.WebDriver.FindElement(_billing_telephone_text).SendKeys(telephone);
        }

        public void BillingClickOnContinue()
        {
            Driver.WebDriver.FindElement(_billing_continue_button).Click();
        }

        public void FillOutBillingForm()
        {
            FillNames("first","middle","last");
            FillAddress("asd@yahoo.com","asd home","asd city");
            FillCountryandState("US","3");
            FillZipPhone("123123","1231231231");
            SelectShippingAddress(true);
            BillingClickOnContinue();
        }

        public void ClickOnShippingEdit()
        {
            Driver.WebDriver.FindElements(_shipping_edit_button).ToArray()[2].Click();
        }



    }
}
