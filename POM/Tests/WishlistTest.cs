using NUnit.Framework;
using POM.Helpers;
using FluentAssertions;

namespace POM.Tests
{
    [TestFixture]
    public class WishlistTest : BaseTest
    {
        [Test]
        [TestCase(0, 1, 2)]
        public void AddToWishlist(int color, int size, int quantity)
        {
            Pages.Header.GoToLogIn();

            Pages.LoginPage.LogIn(Constants.GoodAccountEmail, Constants.GoodAccountPassword);

            Pages.Header.SelectSubcategory(0, 2);

            Pages.ProductCategoryPage.SelectFromProductList();

            Pages.ProductDetailsPage.SelectColor(color);

            Pages.ProductDetailsPage.SelectSize(size);

            Pages.ProductDetailsPage.SelectQuantity(quantity);

            Pages.ProductDetailsPage.AddToWishlist();

            Pages.WishlistPage.ClickOnAddToCart();

            Pages.CartPage.VerifyShoppingCartProduct().Should().BeTrue();
        }

        [Test]
        [TestCase(0, 1, 2)]
        public void DeleteFromWishlist(int color, int size, int quantity)
        {
            Pages.Header.GoToLogIn();

            Pages.LoginPage.LogIn(Constants.GoodAccountEmail, Constants.GoodAccountPassword);

            Pages.Header.SelectSubcategory(0, 2);

            Pages.ProductCategoryPage.SelectFromProductList();

            Pages.ProductDetailsPage.SelectColor(color);

            Pages.ProductDetailsPage.SelectSize(size);

            Pages.ProductDetailsPage.SelectQuantity(quantity);

            Pages.ProductDetailsPage.AddToWishlist();

            Pages.WishlistPage.ClearWishlist(); 

            Pages.WishlistPage.VerifyEmptyWishlist().Should().BeTrue();
        }
    }
}
