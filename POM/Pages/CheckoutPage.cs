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

        private readonly By _billing_first_name_text = By.CssSelector("#billing\\:firstname");
        private readonly By _billing_middle_name_text = By.CssSelector("#billing\\:middlename");
        private readonly By _billing_last_name_text = By.CssSelector("#billing\\:lastname");
        private readonly By _billing_company_text = By.CssSelector("[id=\"billing:company\"]");
        private readonly By _billing_email_text = By.CssSelector("[id=\"billing:email\"]");
        private readonly By _billing_address_1_text = By.CssSelector("[id=\"billing:street1\"]");
        private readonly By _billing_address_2_text = By.CssSelector("[id=\"billing:street2\"]");
        private readonly By _billing_city_text = By.CssSelector("[id=\"billing:city\"]");
        private readonly By _billing_state_select = By.CssSelector("[id=\"billing:region_id\"]");
        private readonly By _billing_state_text = By.CssSelector("[id=\"billing:region\"]");
        private readonly By _billing_postcode_text = By.CssSelector("[id=\"billing:postcode\"]");
        private readonly By _billing_country_select = By.CssSelector("[id=\"billing:country_id\"]");
        private readonly By _billing_telephone_text = By.CssSelector("[id=\"billing:telephone\"]");
        private readonly By _billing_fax_text = By.CssSelector("[id=\"billing:fax\"]");
        private readonly By _billing_same_address_radio_list = By.CssSelector("[name=\"billing[use_for_shipping]\"]");
        private readonly By _billing_continue_button = By.CssSelector("#billing-buttons-container .button");

        private readonly By _shipping_edit_button = By.CssSelector("#opc-shipping .step-title");
        private readonly By _shipping_edit_link = By.CssSelector("#opc-shipping .step-title a");
        private readonly By _shipping_first_name_text = By.CssSelector("[id=\"shipping:firstname\"]");
        private readonly By _shipping_last_name_text = By.CssSelector("[id=\"shipping:lastname\"]");
        private readonly By _shipping_address_1_text = By.CssSelector("[id=\"shipping:street1\"]");
        private readonly By _shipping_city_text = By.CssSelector("[id=\"shipping:city\"]");
        private readonly By _shipping_state_select = By.CssSelector("[id=\"shipping:region_id\"]");
        private readonly By _shipping_state_text = By.CssSelector("[id=\"shipping:region\"]");
        private readonly By _shipping_postcode_text = By.CssSelector("[id=\"shipping:postcode\"]");
        private readonly By _shipping_country_select = By.CssSelector("[id=\"shipping:country_id\"]");
        private readonly By _shipping_telephone_text = By.CssSelector("[id=\"shipping:telephone\"]");
        private readonly By _shipping_continue_button = By.CssSelector("#shipping-buttons-container .button");

        private readonly By _shipping_method_free_radio = By.CssSelector("#s_method_freeshipping_freeshipping");
        private readonly By _shipping_method_flat_radio = By.CssSelector("#s_method_flatrate_flatrate");
        private readonly By _shipping_method_continue_button = By.CssSelector("#shipping-method-buttons-container .button");

        private readonly By _payment_continue_button = By.CssSelector("#payment-buttons-container .button");
        private readonly By _review_place_order_button = By.CssSelector(".button.btn-checkout");

        private readonly By _order_placed_successfully = By.CssSelector(".page-title h1");
        #endregion

        public void SelectGuestOption()
        {
            Driver.WebDriver.FindElement(_guest_option).Click();
            Driver.WebDriver.FindElement(_guest_continue_button).Click();
        }

        public void SelectShippingAddress(bool a)
        {
            if(a)
                Driver.WebDriver.FindElements(_billing_same_address_radio_list).First().Click();
            else
                Driver.WebDriver.FindElements(_billing_same_address_radio_list).Last().Click();
        }

        public void BillingFillNames(string first, string last)
        {
            Driver.WebDriver.FindElement(_billing_first_name_text).SendKeys(first);
            //Driver.WebDriver.FindElement(_billing_middle_name_text).SendKeys(middle);
            Driver.WebDriver.FindElement(_billing_last_name_text).SendKeys(last);
        }

        public void BillingFillAddress(string email, string address, string city) 
        {
            Driver.WebDriver.FindElement(_billing_email_text).SendKeys(email);
            Driver.WebDriver.FindElement(_billing_address_1_text).SendKeys(address);
            Driver.WebDriver.FindElement(_billing_city_text).SendKeys(city);
        }

        private bool IsBillingStateSelectDisplayed()
        {
            return Driver.WebDriver.FindElement(_billing_state_select).Displayed;
        }

        public void BillingFillCountryandState(string country, string state)
        {
            new SelectElement(Driver.WebDriver.FindElement(_billing_country_select)).SelectByValue(country);
            if (IsBillingStateSelectDisplayed() == true)
                new SelectElement(Driver.WebDriver.FindElement(_billing_state_select)).SelectByValue(state);
            else
                Driver.WebDriver.FindElement(_billing_state_text).SendKeys(state);
        }

        public void BillingFillZipPhone(string postcode, string telephone)
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
            BillingFillNames("first","last");
            BillingFillAddress("asd@yahoo.com","asd home","asd city");
            BillingFillCountryandState("US","3");
            BillingFillZipPhone("123123","1231231231");
            SelectShippingAddress(true);
            BillingClickOnContinue();
        }

        public void ClickOnShippingEdit()
        {
            Driver.WebDriver.FindElement(_shipping_edit_button).Click();
        }

        public void ShippingClickOnContinue()
        {
            Driver.WebDriver.FindElement(_shipping_continue_button).Click();
        }

        public void ShippingFillNames(string first, string last)
        {
            Driver.WebDriver.FindElement(_shipping_first_name_text).SendKeys(first);
            Driver.WebDriver.FindElement(_shipping_last_name_text).SendKeys(last);
        }

        public void ShippingFillAddress(string address, string city)
        {
            Driver.WebDriver.FindElement(_shipping_address_1_text).SendKeys(address);
            Driver.WebDriver.FindElement(_shipping_city_text).SendKeys(city);
        }

        private bool IsShippingStateSelectDisplayed()
        {
            return Driver.WebDriver.FindElement(_shipping_state_select).Displayed;
        }

        public void ShippingFillCountrySate(string country, string state)
        {
            new SelectElement(Driver.WebDriver.FindElement(_shipping_country_select)).SelectByValue(country);

            if (IsShippingStateSelectDisplayed())
                new SelectElement(Driver.WebDriver.FindElement(_shipping_state_select)).SelectByValue(state);
            else
                Driver.WebDriver.FindElement(_shipping_state_text).SendKeys(state);
        }

        public void ShippingFillZipPhone(string postalcode, string telephone)
        {
            Driver.WebDriver.FindElement(_shipping_postcode_text).SendKeys(postalcode);
            Driver.WebDriver.FindElement(_shipping_telephone_text).SendKeys(telephone);
        }

        public void FillOutShippingForm()
        {
            WaitHelper.WaitUntilElementVisible(_shipping_edit_link);
            ClickOnShippingEdit();
            ShippingFillNames("first", "last");
            ShippingFillAddress("address", "city");
            ShippingFillCountrySate("US","3");
            ShippingFillZipPhone("123123","1231231231");
            ShippingClickOnContinue();
        }

        public void SelectShippingMethod(string s)
        {
            if (s.Equals("free"))
                Driver.WebDriver.FindElement(_shipping_method_free_radio).Click();
            else
                Driver.WebDriver.FindElement(_shipping_method_flat_radio).Click();
        }

        public void ShippingMethodClickOnContinue()
        {
            Driver.WebDriver.FindElement(_shipping_method_continue_button).Click();
        }

        public void FillShippingMethod()
        {
            WaitHelper.WaitUntilElementVisible(_shipping_method_continue_button);
            SelectShippingMethod("free");
            ShippingMethodClickOnContinue();
        }

        public void PaymentClickOnContinue()
        {
            WaitHelper.WaitUntilElementVisible(_payment_continue_button);
            Driver.WebDriver.FindElement(_payment_continue_button).Click();
        }

        public void ClickOnPlaceOrder()
        {
            WaitHelper.WaitUntilElementVisible(_review_place_order_button);
            Driver.WebDriver.FindElement(_review_place_order_button).Click();
        }

        public bool OrderSuccess()
        {
            return Driver.WebDriver.FindElement(_order_placed_successfully).Displayed;
        }

    }
}
