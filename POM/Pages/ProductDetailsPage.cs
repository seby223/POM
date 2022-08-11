using OpenQA.Selenium;
using System.Linq;
using POM.Helpers;
using OpenQA.Selenium.Support.UI;
using System;

namespace POM.Pages
{
    public class ProductDetailsPage
    {
        #region Selectors

        private readonly By _addToCartButton = By.CssSelector(".btn-cart:not(#map-popup-button)");
        private readonly By _availableColorsList = By.CssSelector("#configurable_swatch_color>li:not(.not-available)");
        private readonly By _colorsList = By.CssSelector("#configurable_swatch_color>li");
        private readonly By _availableSizesList = By.CssSelector("#configurable_swatch_size>li:not(.not-available)");
        private readonly By _sizesList = By.CssSelector("#configurable_swatch_size>li");
        private readonly By _quantity = By.CssSelector("#qty");
        private readonly By _thumbnails = By.CssSelector(".product-image-thumbs >li");
        private readonly By _details = By.CssSelector(".toggle-tabs > li");
        private readonly By _reviewTopButton = By.CssSelector(".rating-links > a:last-child");
        private readonly By _reviewBottomButton = By.CssSelector("#collateral-tabs .no-rating a");
        private readonly By _monogramField = By.CssSelector("#options_3_text");
        private readonly By _customOptionMonogramSelect = By.CssSelector("#select_2");
        private readonly By _reviewQualityList = By.CssSelector("tbody tr:first-child >td");
        private readonly By _reviewPriceList = By.CssSelector("tbody tr:nth-child(2) > td");
        private readonly By _reviewValueList = By.CssSelector("tbody tr:last-child > td");
        private readonly By _reviewThoughtsField = By.CssSelector("#review_field");
        private readonly By _reviewSummaryField = By.CssSelector("#summary_field");
        private readonly By _reviewNicknameField = By.CssSelector("#nickname_field");
        private readonly By _reviewSubmitButton = By.CssSelector(".buttons-set .button");
        private readonly By _addWhislistButton = By.CssSelector(".add-to-links li:first-child");
        private readonly By _reviewSuccessMessage = By.CssSelector(".success-msg");

        #endregion

        public bool IsAddToCartButtonDisplayed()
        {
            return Driver.WebDriver.FindElement(_addToCartButton).Displayed;
        }

        public bool IsAddToCartButtonEnabled()
        {
            return Driver.WebDriver.FindElement(_addToCartButton).Enabled;
        }

        public void ClickOnAddToCart()
        {
            Driver.WebDriver.FindElement(_addToCartButton).Click();
        }

        public void SelectColorFromAll(int Value)
        {
            Driver.WebDriver.FindElements(_colorsList).ToArray()[Value].Click();
        }

        public void SelectColor(int Value) 
        {
            Driver.WebDriver.FindElements(_availableColorsList).ToArray()[Value].Click();
        }

        public void SelectSizeFromAll(int Value)
        {
            Driver.WebDriver.FindElements(_sizesList).ToArray()[Value].Click();
        }

        public void SelectSize(int Value)
        {
            Driver.WebDriver.FindElements(_availableSizesList).ToArray()[Value].Click();
        }

        public void SelectQuantity(int Value)
        {

            var quantity = Driver.WebDriver.FindElement(_quantity);
            quantity.Clear();
            quantity.SendKeys(Value.ToString());
        }

        public void ClickOnThumbnails(int Value)
        {
            Driver.WebDriver.FindElements(_thumbnails).ToArray()[Value].Click();
        }

        private void ClickOnReviewButtonBottom()
        {
            Driver.WebDriver.FindElements(_details).Last().Click();
            Driver.WebDriver.FindElement(_reviewBottomButton).Click();
        }

        private bool IsTopReviewDisplayed()
        {
            try
            {
                return Driver.WebDriver.FindElement(_reviewTopButton).Displayed;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void ClickOnReviewButton()
        {
            if (IsTopReviewDisplayed())
            {
                Driver.WebDriver.FindElement(_reviewTopButton).Click();
            }
            else
                ClickOnReviewButtonBottom();
        }

        public void FillMonogramField(string StringValue)
        {
            Driver.WebDriver.FindElement(_monogramField).SendKeys(StringValue);
        }

        public void SelectCustomOptions(int Value)
        {
            new SelectElement(Driver.WebDriver.FindElement(_customOptionMonogramSelect)).SelectByIndex(Value);
        }

        public void ReviewSelectProductQuality(int value)
        {
            Driver.WebDriver.FindElements(_reviewQualityList)[value].Click();
        }

        public void ReviewSelectProductPrice(int value)
        {
            Driver.WebDriver.FindElements(_reviewPriceList)[value].Click();
        }

        public void ReviewSelectProductValue(int value)
        {
            Driver.WebDriver.FindElements(_reviewValueList)[value].Click();
        }

        public void ReviewFillThoughts(string value)
        {
            Driver.WebDriver.FindElement(_reviewThoughtsField).SendKeys(value);
        }

        public void ReviewFillSummary(string value)
        {
            Driver.WebDriver.FindElement (_reviewSummaryField).SendKeys(value);
        }

        public void ReviewFillNick(string value)
        {
            Driver.WebDriver.FindElement(_reviewNicknameField).SendKeys(value);
        }

        public void ReviewFillIn()
        {
            WaitHelper.WaitUntilElementVisible(_reviewSubmitButton);

            ReviewSelectProductQuality(Faker.RandomNumber.Next(0, 4));
            ReviewSelectProductPrice(Faker.RandomNumber.Next(0, 4));
            ReviewSelectProductValue(Faker.RandomNumber.Next(0, 4));

            ReviewFillThoughts(Faker.Name.FullName());
            ReviewFillSummary(Faker.Name.FullName());
            ReviewFillNick(Faker.Name.First());
        }

        public void ReviewClickSubmit()
        {
            Driver.WebDriver.FindElement(_reviewSubmitButton).Click();
        }

        public bool ReviewSuccess()
        {
            return Driver.WebDriver.FindElement(_reviewSuccessMessage).Displayed;
        }
        
        public void AddToWishlist()
        {
            Driver.WebDriver.FindElement(_addWhislistButton).Click();
        }
    }
}
    