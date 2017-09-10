
using NHtmlUnit;
using NHtmlUnit.Html;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XmlOku;

namespace Testiing
{
    [TestFixture]
    public class UnitTest
    {
        [TestCase]
        public void test1()
        {
            NHtmlUnit.WebClient driver=null;
            driver = new NHtmlUnit.WebClient(BrowserVersion.INTERNET_EXPLORER_11);
            driver.Options.JavaScriptEnabled = true;
           driver.Options.ThrowExceptionOnScriptError = false;
            driver.Options.ActiveXNative = true;
            driver.Options.CssEnabled = true;
            HtmlPage page = driver.GetHtmlPage("https://www.expedia.com/");

            Assert.AreEqual("Google", page.TitleText);
        }

        [TestCase]
        public void test2()
        {
         string sakla =   readTxt.readtxtfile();
            Assert.AreEqual(1, sakla);
        }
    }
}
