using NsTestFrameworkUI.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace POM.Helpers
{
    public static class WaitHelper
    {
        //new WebDriverWait(Driver.WebDriver, TimeSpan.FromSeconds(30.0))
        //     .Until(d => Driver.WebDriver.ExecuteScript("return document.readyState").Equals("complete"));
        public static void WaitUntilElementVisible(By Selector)
        {
            new WebDriverWait(Driver.WebDriver, TimeSpan.FromSeconds(10.0)).Until(d=>Driver.WebDriver.FindElement(Selector).Displayed);
        }
    }
}
