using POM.Helpers;
using NUnit.Framework;
using FluentAssertions;
using System.Threading;

namespace POM.Tests
{
    [TestFixture]
    public class SystemTest : BaseTest
    {
        [Test]
        public void Checkout()
        {
            Pages.HomePage.Search("swiss");

            Pages.SearchResultsPage.GoToDetailsPageOfFirstItem();

            Pages.ProductDetailsPage.ClickOnAddToCart();

            Pages.CartPage.ClickOnCheckoutButton();

            Pages.CheckoutPage.SelectGuestOption();
            
            Pages.CheckoutPage.FillOutBillingForm();
            //WaitHelpers.WaitUntilDocumentReady();
            Thread.Sleep(7000);

            Pages.CheckoutPage.FillOutShippingForm();

            /*Pages.CheckoutPage.FillShippingMethod();

            /*Pages.CheckoutPage.PaymentClickOnContinue();

            /*Pages.CheckoutPage.ClickOnPlaceOrder();

            /*Pages.CheckoutPage.OrderSuccess().Should().BeTrue();*/

        }
    }
}
