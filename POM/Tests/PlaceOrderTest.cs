using POM.Helpers;
using NUnit.Framework;
using FluentAssertions;
using System.Threading;

namespace POM.Tests
{
    [TestFixture]
    public class PlaceOrderTest : BaseTest
    {
        [Test]
        public void Order1Item()
        {
            Pages.HomePage.Search("swiss");

            Pages.SearchResultsPage.GoToDetailsPageOfFirstItem();

            Pages.ProductDetailsPage.ClickOnAddToCart();

            Pages.CartPage.ClickOnCheckoutButton();

            Pages.CheckoutPage.SelectGuestOption();
            
            Pages.CheckoutPage.FillOutBillingForm();
            //WaitHelpers.WaitUntilDocumentReady();
            Thread.Sleep(10000);

            Pages.CheckoutPage.FillOutShippingForm();
            Thread.Sleep(5000);

            Pages.CheckoutPage.FillShippingMethod();
            Thread.Sleep(5000);

            Pages.CheckoutPage.PaymentClickOnContinue();
            Thread.Sleep(5000);

            Pages.CheckoutPage.ClickOnPlaceOrder();

            Pages.CheckoutPage.OrderSuccess().Should().BeTrue();

        }
    }
}
