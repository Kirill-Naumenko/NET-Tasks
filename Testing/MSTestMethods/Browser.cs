using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MSTestMethods
{
    public class Browser
    {

        FirefoxDriver driver;
        
        

        public Browser()
        {
            driver = new FirefoxDriver();
        }

        public string MoveToUrl(string url)
        {
            driver.Navigate();
            driver.Url = url;
            return driver.Url = url;
        }

        

        public string Open(string url)
        {
            driver.Navigate();
            driver.Url = url;
            return driver.Title;
        }

        public bool Close()
        {
            if (driver != null)
            {
                driver.Quit();
                driver = null;
                return true;
            }
            return false;
        }

        public void ThrowExeption()
        {
            throw new DivideByZeroException();
        }

    }
}
