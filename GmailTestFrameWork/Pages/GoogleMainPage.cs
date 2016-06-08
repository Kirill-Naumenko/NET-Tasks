using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pages
{
    public class GoogleMainPage : BasePage
    {
        public const string BASE_URL = "https://google.com/";

        [FindsBy(How = How.Id, Using = "gb_70")]
        private IWebElement buttonSignIntoGmail { get; set; }

        public GoogleMainPage (IWebDriver driver) : base(driver)
        {

        }

        public GoogleMainPage Open()
        {
            driver.Navigate().GoToUrl(BASE_URL);
            return new GoogleMainPage(driver);
        }

        public GmailLogInPage LogInGmail()
        {
            buttonSignIntoGmail.Click();
            return new GmailLogInPage(driver);

        }

    }
}
