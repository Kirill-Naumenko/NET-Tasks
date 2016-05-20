using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drivers
{
    public sealed class WebDriver
    {

        private static IWebDriver _driver = null;
        private static readonly object padlock = new object();

        private WebDriver() { }

        public static IWebDriver GetDriver()
        {

            if (_driver == null)
            {
                lock (padlock)
                {
                    switch (ConfigurationManager.AppSettings["browser"])
                    {
                        case "GoogleChrome":
                            _driver = new ChromeDriver();
                            return _driver;

                        case "FireFox":
                            _driver = new FirefoxDriver();
                            return _driver;

                        case "InternetExplorer":
                            _driver = new InternetExplorerDriver();
                            return _driver;
                    }

                }
            }
           
            return _driver;
        }


        private void Kill() // ;)
        {
            if (_driver != null)
            {
                _driver.Quit();
                _driver = null;
            }
        }

    }
}
