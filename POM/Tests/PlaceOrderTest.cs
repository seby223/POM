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
            Pages.Header.Search(Constants.ItemForPlaceOrder);

            Pages.SearchResultsPage.GoToDetailsPageOfFirstItem();

            Pages.ProductDetailsPage.ClickOnAddToCart();

            Pages.CartPage.ClickOnCheckoutButton();

            Pages.CheckoutPage.CheckoutAsGuest();

            Pages.CheckoutPage.ClickContinueButton();

            Pages.CheckoutBillingPage.FillOutForm();

            Pages.CheckoutShippingPage.FillOutForm();

            Pages.CheckoutShippingMethodPage.FillOutForm();

            Pages.CheckoutPaymentPage.PaymentClickOnContinue();

            Pages.CheckoutReviewOrderPage.ClickOnPlaceOrder();

            Pages.CheckoutReviewOrderPage.OrderSuccess().Should().BeTrue();
        }

        [Test]
        public void Order1ItemClient()
        {
            Pages.Header.GoToLogIn();

            Pages.LoginPage.LogIn(Constants.GoodAccountNoItemsEmail, Constants.GoodAccountNoItemsPassword);

            Pages.Header.Search(Constants.ItemForPlaceOrder);

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

