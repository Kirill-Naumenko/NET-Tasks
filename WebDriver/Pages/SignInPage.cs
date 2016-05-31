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
    public class SignInPage
    {
        public const string BASE_URL = "https://accounts.google.com/ServiceLogin?hl=be&passive=true&continue=https://www.google.by/";
        private IWebDriver driver;


        [FindsBy(How = How.Id, Using = "Email")]
        private IWebElement tfInputEmail { get; set; }

        [FindsBy(How = How.Id, Using = "next")]
        private IWebElement btnNext { get; set; }

        [FindsBy(How = How.Id, Using = "Passwd")]
        private IWebElement tfInputPassword { get; set; }

        [FindsBy(How = How.Id, Using = "signIn")]
        private IWebElement btnSignIn { get; set; }

        [FindsBy(How = How.Id, Using = "PersistentCookie")]
        private IWebElement cbStaySignIn { get; set; }

        public SignInPage(IWebDriver driver)
        {
            this.driver = driver;
            this.driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
            PageFactory.InitElements(this.driver, this);
        }

        public void Open()
        {
            driver.Navigate().GoToUrl(BASE_URL);
        }
               
        public void LogIn(string login , string password)
        {
            tfInputEmail.SendKeys(login);
            btnNext.Click();
            tfInputPassword.SendKeys(password);
            if (cbStaySignIn.Selected)
            {
                cbStaySignIn.Click();
            }
            btnSignIn.Click();
        }
    }
}
