using POM.Helpers;
using NUnit.Framework;
using FluentAssertions;

namespace POM.Tests
{
    [TestFixture]
    public class ProductDetailsPageTest : BaseTest
    {

        [Test]
        public void AddToCartButtonIsDisplayed()
        {
            Pages.Header.Search("Chelsea Tee");

            Pages.SearchResultsPage.GoToDetailsPageOfFirstItem();

            Pages.ProductDetailsPage.IsAddToCartButtonDisplayed().Should().BeTrue();
        }

        [Test]
        public void ReviewTest()
        {

        }
    }
}
