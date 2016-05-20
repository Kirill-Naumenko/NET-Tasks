using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pages.SettingsPage
{
    public class FrowardSettingsPage
    {

        private IWebDriver driver;


        public FrowardSettingsPage(IWebDriver driver)
        {
            this.driver = driver;
            this.driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
            PageFactory.InitElements(this.driver, this);
        }


        [FindsBy(How = How.XPath, Using = "//input[contains(@act , 'add')]")]
        public IWebElement btnAddForwardAdress { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[contains(@type, 'text') and contains(@size, '48')]")]
        public IWebElement tfAddForwardAdress { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[contains(@type, 'submit') and contains(@style, 'bold')]")]
        public IWebElement btConfirmForwardingAdress { get; set; }

        public void SetForwardUser(string login)
        {
            btnAddForwardAdress.Click();
            tfAddForwardAdress.SendKeys(login);
            btConfirmForwardingAdress.Click();
        }
        

    }
}
