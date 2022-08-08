using OpenQA.Selenium;
using System.Linq;
using POM.Helpers;
using OpenQA.Selenium.Support.UI;

namespace POM.Pages
{
    public class ProductDetailsPage : Header
    {
        #region Selectors

        private readonly By _addToCartButton = By.CssSelector(".btn-cart:not(#map-popup-button)");
        private readonly By _colors_list = By.CssSelector("#configurable_swatch_color>li:not(.not-available)");
        private readonly By _sizes_list = By.CssSelector("#configurable_swatch_size>li:not(.not-available)");
        private readonly By _quantity = By.CssSelector("#qty");
        private readonly By _thumbnails = By.CssSelector(".product-image-thumbs >li");
        private readonly By _details = By.CssSelector(".toggle-tabs > li");
        private readonly By _review_top_button = By.CssSelector(".rating-links > a:last-child");
        private readonly By _review_bottom_button = By.CssSelector("#collateral-tabs .no-rating a");
        private readonly By _monogram_field = By.CssSelector("#options_3_text");
        private readonly By _custom_option_monogram_select = By.CssSelector("#select_2");
        private readonly By _regular_price = By.CssSelector(".price");
        private readonly By _review_quality_list = By.CssSelector("tbody tr:first-child >td");
        private readonly By _review_price_list = By.CssSelector("tbody tr:nth-child(2) > td");
        private readonly By _review_value_list = By.CssSelector("tbody tr:last-child > td");
        private readonly By _review_thoughts_field = By.CssSelector("#review_field");
        private readonly By _review_summary_field = By.CssSelector("#summary_field");
        private readonly By _review_nickname_field = By.CssSelector("#nickname_field");
        private readonly By _review_submit_button = By.CssSelector(".buttons-set .button");
        private readonly By _zoom_view = By.CssSelector(".zoomWindow");
        private readonly By _add_whislist_button = By.CssSelector(".add-to-links li:first-child");
        private readonly By _add_compare_button = By.CssSelector(".add-to-links li:last-child");

        #endregion

        public bool IsAddToCartButtonDisplayed()
        {
            return Driver.WebDriver.FindElement(_addToCartButton).Displayed;
        }

        public void ClickOnAddToCart()
        {
            Driver.WebDriver.FindElement(_addToCartButton).Click();
        }

        public void SelectColor(int Value) 
        {
            Driver.WebDriver.FindElements(_colors_list).ToArray()[Value].Click();
        }

        public void SelectSize(int Value)
        {
            Driver.WebDriver.FindElements(_sizes_list).ToArray()[Value].Click();
        }

        public void SelectQuantity(int Value)
        {
            Driver.WebDriver.FindElement(_quantity).SendKeys(Value.ToString());
        }

        public void ClickOnThumbnails(int Value)
        {
            Driver.WebDriver.FindElements(_thumbnails).ToArray()[Value].Click();
        }

        private void ClickOnReviewButtonBottom()
        {
            Driver.WebDriver.FindElements(_details).Last().Click();
            Driver.WebDriver.FindElement(_review_bottom_button).Click();
        }

        public bool IsTopReviewDisplayed()
        {
            return Driver.WebDriver.FindElement(_review_top_button).Displayed;
        }

        public void ClickOnReviewButton()
        {
            if (IsTopReviewDisplayed())
            {
                Driver.WebDriver.FindElement(_review_top_button).Click();
            }
            else
                ClickOnReviewButtonBottom();
        }

        public void FillMonogramField(string StringValue)
        {
            Driver.WebDriver.FindElement(_monogram_field).SendKeys(StringValue);
        }

        public void SelectCustomOptions(int Value)
        {
            new SelectElement(Driver.WebDriver.FindElement(_custom_option_monogram_select)).SelectByIndex(Value);
        }


    }
}
