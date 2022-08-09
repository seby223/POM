using POM.Helpers;
using NUnit.Framework;
using FluentAssertions;

namespace POM.Tests
{
    [TestFixture]
    public class MaterialDetailsPageTest : BaseTest
    {
        /*([Test]
        public void Test1HomePage()
        {
            
            Pages.HomePage.ClickLogo();

            Pages.HomePage.ClickOnWomenCategory();

            Driver.WebDriver.Navigate().Back();
            Driver.WebDriver.Navigate().Forward();
            Driver.WebDriver.Navigate().Refresh();

            Assert.That(Driver.WebDriver.Url, Is.EqualTo("http://qa1magento.dev.evozon.com/women.html"));
            //Driver.Url.Should().Be("http://qa1magento.dev.evozon.com/women.html");
        }*/

        [Test]
        public void AddToCartButtonIsDisplayed()
        {
            Pages.Header.Search("Chelsea Tee");

            Pages.SearchResultsPage.GoToDetailsPageOfFirstItem();

            Pages.ProductDetailsPage.IsAddToCartButtonDisplayed().Should().BeTrue();
        }
    }
}
