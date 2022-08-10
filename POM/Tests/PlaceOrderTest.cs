using POM.Helpers;
using NUnit.Framework;
using FluentAssertions;


namespace POM.Tests
{
    [TestFixture]
    public class PlaceOrderTest : BaseTest
    {
        [Test]
        public void Order1ItemGuest()
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

        [Test]
        public void Order1ItemClient()
        {
            Pages.Header.GoToLogIn();

            Pages.LoginPage.LogIn(Constants.GOODACCOUNTNOITEMSEMAIL, Constants.GOODACCOUNTNOITEMSPASS);

            Pages.Header.Search("swiss");

            Pages.SearchResultsPage.GoToDetailsPageOfFirstItem();

            Pages.ProductDetailsPage.ClickOnAddToCart();

            Pages.CartPage.ClickOnCheckoutButton();

            Pages.CheckoutBillingPage.SelectSameShippingAddress(true);

            Pages.CheckoutBillingPage.ClickOnContinue();

            Pages.CheckoutShippingPage.SameAddressClientContinue();

            Pages.CheckoutShippingMethodPage.FillOutForm();

            Pages.CheckoutPaymentPage.PaymentClickOnContinue();

            Pages.CheckoutReviewOrderPage.ClickOnPlaceOrder();

            Pages.CheckoutReviewOrderPage.OrderSuccess().Should().BeTrue();
        }
    }
}

