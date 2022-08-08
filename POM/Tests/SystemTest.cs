using POM.Helpers;
using NUnit.Framework;
using FluentAssertions;

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



        }
    }
}
