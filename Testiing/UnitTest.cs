using NHtmlUnit.Html;
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
            NHtmlUnit.WebClient driver = new NHtmlUnit.WebClient();

            driver.Options.JavaScriptEnabled = true;
            driver.Options.ThrowExceptionOnScriptError = false;
            driver.Options.ActiveXNative = true;
            driver.Options.CssEnabled = true;

            HtmlPage page = driver.GetHtmlPage("https://www.google.com.tr");

            Assert.AreNotEqual("Google", page.TitleText);
        }

        [TestCase]
        public void test2()
        {
            Assert.AreEqual(1, 1);
        }
    }
}
