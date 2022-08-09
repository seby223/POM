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
        public void ReviewNewProductTest()
        {
            Pages.HomePage.ClickOnNewProduct(Faker.RandomNumber.Next(0,4));

            Pages.ProductDetailsPage.ClickOnReviewButton();

            Pages.ProductDetailsPage.ReviewFillIn();

            Pages.ProductDetailsPage.ReviewClickSubmit();

            Pages.ProductDetailsPage.ReviewSuccess().Should().BeTrue();

        }

        [Test]
        public void AddToCartButtonDisabledForOutOfStockItems()
        {
            Pages.Header.Search("elizabeth");

            Pages.SearchResultsPage.GoToDetailsPageOfFirstItem();

            Pages.ProductDetailsPage.SelectColorFromAll(0);

            Pages.ProductDetailsPage.SelectSizeFromAll(0);

            Pages.ProductDetailsPage.IsAddToCartButtonEnabled().Should().BeFalse();
        }
    }
}
