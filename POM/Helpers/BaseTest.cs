using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;

namespace POM.Helpers
{
    public class BaseTest
    {
       

        [SetUp]
        public void Setup()
        {
            Driver.WebDriver = new ChromeDriver("C:\\Users\\Seby\\Desktop\\C#ProjectsEvozon\\TestProject1\\TestProject1\\Drivers");
            Driver.WebDriver.Navigate().GoToUrl("http://qa2magento.dev.evozon.com/");
            WaitHelpers.WaitUntilDocumentReady();
        }

        [TearDown]
        public void TearDown()
        {
            Driver.WebDriver.Close();
            Driver.WebDriver.Quit();
        }
    }
}
