﻿using OpenQA.Selenium;
using System.Linq;
using POM.Helpers;

namespace POM.Pages
{
    public class AccountPage
    {
        #region Selectors

        private readonly By _hello_message = By.CssSelector(".hello strong");

        #endregion
        public bool VerifyHelloMessage(string message)
        {
            //WaitHelpers.WaitUntilElementVisible(_hello_message);
            return Driver.WebDriver.FindElement(_hello_message).Text.Equals(message);
        }
    }
}
