using NUnit.Framework;
using POM.Helpers;
using FluentAssertions;

namespace POM.Tests
{
    [TestFixture]
    public class CartTest:BaseTest
    {
        [Test]
        public void CorrectCountOnMinicart()
        {
            Pages.HomePage.ClickOnNewProduct(0);
            Pages.ProductDetailsPage.SelectColor(0);
            Pages.ProductDetailsPage.SelectSize(0);
            Pages.ProductDetailsPage.ClickOnAddToCart();
            Pages.Header.GetProductCount().Should().Be("1");
        }
    }
}
