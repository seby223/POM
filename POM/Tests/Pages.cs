using POM.Helpers;
using POM.Pages;
using SeleniumExtras.PageObjects;
 
namespace POM.Tests
{
    public static class Pages
    {

        public static HomePage HomePage => InitPage(new HomePage());
        public static SearchResultsPage SearchResultsPage => InitPage(new SearchResultsPage());
        public static ProductDetailsPage ProductDetailsPage => InitPage(new ProductDetailsPage());
        public static CartPage CartPage => InitPage(new CartPage());
        public static CheckoutPage CheckoutPage => InitPage(new CheckoutPage());
        public static Header Header => InitPage(new Header());
        public static LoginPage LoginPage => InitPage(new LoginPage());
        public static AccountPage AccountPage => InitPage(new AccountPage());
        public static RegisterPage RegisterPage => InitPage(new RegisterPage());
        public static CheckoutBillingPage CheckoutBillingPage => InitPage(new CheckoutBillingPage());
        public static CheckoutShippingPage CheckoutShippingPage => InitPage(new CheckoutShippingPage());
        public static CheckoutShipMethodPage CheckoutShippingMethodPage => InitPage(new CheckoutShipMethodPage());
        public static CheckoutPaymentPage CheckoutPaymentPage => InitPage(new CheckoutPaymentPage());
        public static CheckoutReviewOrderPage CheckoutReviewOrderPage => InitPage(new CheckoutReviewOrderPage());
        public static T InitPage<T> (T page)
        {
            PageFactory.InitElements (Driver.WebDriver, page);
            return page;
        }
    }
}
//asd