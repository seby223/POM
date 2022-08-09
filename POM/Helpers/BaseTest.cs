using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace POM.Helpers
{
    public class BaseTest
    {

        [SetUp]
        public void Setup()
        {
            Driver.WebDriver = new ChromeDriver(Constants.DRIVERPATH);
            Driver.WebDriver.Navigate().GoToUrl(Constants.WEBSITE);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.WebDriver.Close();
            Driver.WebDriver.Quit();
        }
    }
}
