using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace POM.Helpers
{
    public static class WaitHelper
    {
        public static void WaitUntilElementVisible(By selector)
        {
            new WebDriverWait(Driver.WebDriver, TimeSpan.FromSeconds(10.0)).Until(d=>Driver.WebDriver.FindElement(selector).Displayed);
        }
    }
}
