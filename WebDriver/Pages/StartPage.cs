using Drivers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pages
{
    public class StartPage
    {

       
        public const string Base_Url = "https://google.com/";
        private IWebDriver driver;

        [FindsBy(How = How.Id, Using = "gb_70")]
        private IWebElement btnSignIntoGmail { get; set; }


        public StartPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }

        public void Open()
        {
            driver.Navigate().GoToUrl(Base_Url);
        }

        public void LogInGmail()
        {
            btnSignIntoGmail.Click();
            
        }

    }
}
