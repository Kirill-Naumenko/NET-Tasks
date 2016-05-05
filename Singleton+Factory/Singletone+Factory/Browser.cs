using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singletone_Factory
{
    public sealed class Browser
    {

        private static IWebDriver _driver = null;
        private static readonly object padlock = new object();

        private Browser() { }

        public static IWebDriver GetInstance()
        {

            switch (ConfigurationManager.AppSettings["browser"])
            {

                case "GoogleChrome":

                    if (_driver == null)
                    {
                        lock (padlock)
                        {
                            if (_driver == null)
                            {
                                _driver = new ChromeDriver();
                            }
                        }
                    }
                    return _driver;
                    


                case "FireFox":

                    if (_driver == null)
                    {
                        lock (padlock)
                        {
                            if (_driver == null)
                            {
                                _driver = new FirefoxDriver();
                            }
                        }
                    }
                    return _driver;


            }


            //throw new FormatException();
            return _driver;
                
            }


        public static void Close()
        {
            if( _driver != null)
            {
                _driver.Quit();
                _driver = null;
            }
        }



    }


    

}
