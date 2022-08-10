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
            
            //Pages.CheckoutPage.FillOutBillingForm();
            Pages.CheckoutBillingPage.FillOutForm();

            //Pages.CheckoutPage.FillOutShippingForm();
            Pages.CheckoutShippingPage.FillOutForm();

            //Pages.CheckoutPage.FillShippingMethod();
            Pages.CheckoutShippingMethodPage.FillOutForm();

            //Pages.CheckoutPage.PaymentClickOnContinue();
            Pages.CheckoutPaymentPage.PaymentClickOnContinue();

            //Pages.CheckoutPage.ClickOnPlaceOrder();
            Pages.CheckoutReviewOrderPage.ClickOnPlaceOrder();

            Pages.CheckoutReviewOrderPage.OrderSuccess().Should().BeTrue();

        }
    }
}
