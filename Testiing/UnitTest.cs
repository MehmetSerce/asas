﻿
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
            string dosya_yolu = "C:\\projects\\asas\\Testiing\\TextFile1.txt";
            //string dosya_yolu = "C:\\Users\\User\\source\\repos\\WindowsFormsApp1\\Testiing\\TextFile1.txt";
        
         //Okuma işlem yapacağımız dosyanın yolunu belirtiyoruz.
         FileStream fs = new FileStream(dosya_yolu, FileMode.Open, FileAccess.Read);
            //Bir file stream nesnesi oluşturuyoruz. 1.parametre dosya yolunu,
            //2.parametre dosyanın açılacağını,
            //3.parametre dosyaya erişimin veri okumak için olacağını gösterir.
            StreamReader sw = new StreamReader(fs);
            //Okuma işlemi için bir StreamReader nesnesi oluşturduk.
            string yazi = sw.ReadLine();
            while (yazi != null)
            {
                Console.WriteLine(yazi);
                yazi = sw.ReadLine();
            }
            //Satır satır okuma işlemini gerçekleştirdik ve ekrana yazdırdık
            //Son satır okunduktan sonra okuma işlemini bitirdik
            sw.Close();
            fs.Close();
            Assert.AreEqual(1, 1);
        }
    }
}
