using NUnit.Framework;
using POM.Helpers;
using FluentAssertions;

namespace POM.Tests
{
    [TestFixture]
    public class WishlistTest : BaseTest
    {
        [Test]
        public void AddToWishlist()
        {
            Pages.Header.GoToLogIn();

            Pages.LoginPage.LogIn(Constants.GOODACCOUNTEMAIL, Constants.GOODACCOUNTPASSWORD);

            Pages.Header.HoverCategory();

            Pages.ProductCategoryPage.SelectFromProductList();

            Pages.ProductDetailsPage.SelectColor(0);

            Pages.ProductDetailsPage.SelectSize(0);

            Pages.ProductDetailsPage.SelectQuantity(5);

            Pages.ProductDetailsPage.AddToWishlist();

        }
    }
}
