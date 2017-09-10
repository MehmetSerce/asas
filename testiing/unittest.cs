
using NHtmlUnit;
using NHtmlUnit.Html;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
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
        //
        [TestCase]
        public void testBrowserStack()
        {
            var driver = new FirefoxDriver();
            var driverService = FirefoxDriverService.CreateDefaultService();
            driverService.FirefoxBinaryPath = @"C:\Program Files (x86)\Mozilla Firefox\firefox.exe";
            driverService.HideCommandPromptWindow = true;
            driverService.SuppressInitialDiagnosticInformation = true;
            driver = new FirefoxDriver(driverService, new FirefoxOptions(), TimeSpan.FromSeconds(60));
            driver.Navigate().GoToUrl("https://www.google.com");
            string title = driver.Title;
            driver.Quit();
            driver.Close();
            Assert.AreEqual("Google2", title);


            //IWebDriver driver;
            //DesiredCapabilities capability = DesiredCapabilities.Firefox();
            //capability.SetCapability("browserstack.user", "mehmetserce1");
            //capability.SetCapability("browserstack.key", "fxrxXXDT9xYmgkLSzqLs");

            //driver = new RemoteWebDriver(
            //  new Uri("http://hub-cloud.browserstack.com/wd/hub/"), capability
            //);
            //driver.Navigate().GoToUrl("http://www.google.com");
            //Console.WriteLine(driver.Title);

            //IWebElement query = driver.FindElement(By.Name("q"));
            //query.SendKeys("Browserstack");
            //query.Submit();
            //Console.WriteLine(driver.Title);

            //driver.Quit();
        }

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
