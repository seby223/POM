using OpenQA.Selenium.Support.UI;
using System;

namespace POM.Helpers
{
    public static class WaitHelpers
    {
        public static void WaitUntilDocumentReady()
        {
            new WebDriverWait(Driver.WebDriver, TimeSpan.FromSeconds(30.0))
            .Until(d => Driver.WebDriver.ExecuteScript("return document.readyState").Equals("complete"));
        }
    }
}
