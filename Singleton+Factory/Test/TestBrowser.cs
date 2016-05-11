using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Singletone_Factory;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace Test
{
    [TestClass]
    public class TestBrowser
    {


        [TestMethod]
        public void Test()
        {

            IWebDriver browser = BrowserFactory.GetBrowser();

            browser.Navigate().GoToUrl("epam.com");
            //Assert.Equals("EPAM &#x7c; Software Product Development Services", browser.Title);
            browser.Close();
            

        }
    }
}
