
using Driver;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pages
{
    public class GmailLogInPage : BasePage
    {
        public const string BASE_URL = "https://accounts.google.com/ServiceLogin?hl=be&passive=true&continue=https://www.google.by/";


        [FindsBy(How = How.Id, Using = "Email")]
        private IWebElement textfieldInputEmail { get; set; }

        [FindsBy(How = How.Id, Using = "next")]
        private IWebElement buttonNext { get; set; }

        [FindsBy(How = How.Id, Using = "Passwd")]
        private IWebElement textfieldInputPassword { get; set; }

        [FindsBy(How = How.Id, Using = "signIn")]
        private IWebElement buttonSignIn { get; set; }

        [FindsBy(How = How.Id, Using = "PersistentCookie")]
        private IWebElement checkboxStaySignIn { get; set; }

        public GmailLogInPage(IWebDriver driver) : base(driver)
        {

        }

        public GmailLogInPage Open()
        {
            driver.Navigate().GoToUrl(BASE_URL);
            return new GmailLogInPage(driver);
        }

        public MailPage LogIn(User user)
        {
            textfieldInputEmail.SendKeys(user.login);
            buttonNext.Click();
            textfieldInputPassword.SendKeys(user.password);
            if (checkboxStaySignIn.Selected)
            {
                checkboxStaySignIn.Click();
            }
            buttonSignIn.Click();
            return new MailPage(driver);
        }
    }
}
