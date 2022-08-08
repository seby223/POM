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

        public static T InitPage<T> (T page)
        {
            PageFactory.InitElements (Driver.WebDriver, page);
            return page;
        }
    }
}
