using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testiing
{
    [TestFixture]
    public class UnitTest
    {
        [TestCase]
        public void test1()
        {
            // You may use any WebDriver implementation. Firefox is used here as an example
            IWebDriver driver = new OpenQA.Selenium.Chrome.ChromeDriver();

            // A "base url", used by selenium to resolve relative URLs
            String baseUrl = "http://www.google.com";
            driver.Navigate().GoToUrl(baseUrl);
            Assert.AreEqual(1, 1);
        }

        [TestCase]
        public void test2()
        {
            Assert.AreEqual(1, 1);
        }
    }
}
