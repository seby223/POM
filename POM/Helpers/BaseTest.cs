using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace POM.Helpers
{
    public class BaseTest
    {

        [SetUp]
        public void SetUp()
        {
            Driver.WebDriver = new ChromeDriver(Constants.DriverPath);
            Driver.WebDriver.Navigate().GoToUrl(Constants.Website);
            Driver.WebDriver.Manage().Window.Maximize();
        }

        [TearDown]
        public void TearDown()
        {
            Driver.WebDriver.Close();
            Driver.WebDriver.Quit();
        }
    }
}
