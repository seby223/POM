using NUnit.Framework;
using POM.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POM.Tests
{
    [TestFixture]
    internal class SearchTest : BaseTest
    {
        [Test]
        public void SearchResult()
        {

            Pages.Header.Search("dress");
            Pages.SearchResultsPage.SelectFromDressList();
        }
    }
}
