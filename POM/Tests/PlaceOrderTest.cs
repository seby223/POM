using POM.Helpers;
using NUnit.Framework;
using FluentAssertions;


namespace POM.Tests
{
    [TestFixture]
    public class PlaceOrderTest : BaseTest
    {
        [Test]
        public void Order1Item()
        {
            Pages.Header.Search("swiss");

            Pages.SearchResultsPage.GoToDetailsPageOfFirstItem();

            Pages.ProductDetailsPage.ClickOnAddToCart();

            Pages.CartPage.ClickOnCheckoutButton();

            Pages.CheckoutPage.SelectGuestOption();
            
            Pages.CheckoutPage.FillOutBillingForm();

            Pages.CheckoutPage.FillOutShippingForm();

            Pages.CheckoutPage.FillShippingMethod();

            Pages.CheckoutPage.PaymentClickOnContinue();

            Pages.CheckoutPage.ClickOnPlaceOrder();

            Pages.CheckoutPage.OrderSuccess().Should().BeTrue();

        }
    }
}
//ceva
