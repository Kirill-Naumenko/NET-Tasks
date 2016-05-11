using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singletone_Factory
{
    public sealed class BrowserFactory
    {

        private static IWebDriver _driver = null;
        private static readonly object padlock = new object();

        private BrowserFactory() { }

        public static IWebDriver GetBrowser()
        {

            if (_driver == null)
            {
                lock (padlock)
                {
                    switch (ConfigurationManager.AppSettings["browser"])
                    {
                        case "GoogleChrome":
                            _driver = ChromeDriverFactory.GetDriver();
                            return _driver;

                        case "FireFox":
                            _driver = FireFoxDriverFactory.GetDriver();
                            return _driver;
                    }

                }
            }
            //throw new FormatException();
            return _driver;
        }


        private void Close()
        {
            if( _driver != null)
            {
                _driver.Quit();
                _driver = null;
            }
        }


    }
}
