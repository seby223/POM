using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POM.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using POM.Pages;
using FluentAssertions;

namespace POM.Tests
{
    [TestFixture]
    public class MaterialDetailsPageTest : BaseTest
    {
        /*([Test]
        public void Test1HomePage()
        {
            
            Pages.HomePage.ClickLogo();

            Pages.HomePage.ClickOnWomenCategory();

            Driver.WebDriver.Navigate().Back();
            Driver.WebDriver.Navigate().Forward();
            Driver.WebDriver.Navigate().Refresh();

            Assert.That(Driver.WebDriver.Url, Is.EqualTo("http://qa1magento.dev.evozon.com/women.html"));
            //Driver.Url.Should().Be("http://qa1magento.dev.evozon.com/women.html");
        }*/

        [Test]
        public void AddToCartButtonIsDisplayed()
        {
            Pages.HomePage.Search();

            Pages.SearchResultsPage.GoToDetailsPage();

            Pages.ProductDetailsPage.IsAddToCartButtonDisplayed().Should().BeTrue();
        }
    }
}
