using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using POM.Helpers;

namespace POM.Tests
{
    [TestFixture]
    public class CartTest:BaseTest
    {
        [Test]
        public void CorrectCountOnMinicart()
        {

            Pages.HomePage.ClickOnNewProduct(0);
            Pages.ProductDetailsPage.SelectColor(0);
            Pages.ProductDetailsPage.SelectSize(0);
            Pages.ProductDetailsPage.ClickOnAddToCart();
            Assert.That(Pages.Header.GetProductCount(), Is.EqualTo("1"));
        }
    }
}
