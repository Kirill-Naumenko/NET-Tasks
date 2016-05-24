using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pages.SettingsPage
{
    public class ForwardSettingsPage
    {

        private IWebDriver driver;


        public ForwardSettingsPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }


        [FindsBy(How = How.XPath, Using = "//input[contains(@act , 'add')]")]
        public IWebElement btnAddForwardAdress { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[contains(@type, 'text') and contains(@size, '48')]")]
        public IWebElement tfAddForwardAdress { get; set; }


        [FindsBy(How = How.Name, Using = "next")]
        public IWebElement btConfirmForwardingAdressNext { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[contains(@type, 'submit')]")]
        public IWebElement btConfirmForwardingAdress { get; set; }
        [FindsBy(How = How.XPath,Using ="//button[contains(@class,'auR') and contains(@name,'ok')]")]
        public IWebElement btnConfirmForwardingOK { get; set; }
        

        [FindsBy(How = How.Name, Using = "sx_em")]
        public IWebElement rbtnFrowardCopyTo { get; set; }

        public void SetForwardUser(string login)
        {
            btnAddForwardAdress.Click();
            tfAddForwardAdress.SendKeys(login);
            btConfirmForwardingAdressNext.Click();

            var currentHandle = driver.CurrentWindowHandle;
            var handles = driver.WindowHandles;
            foreach (var handle in handles)
            {
                driver.SwitchTo().Window(handle);
            }
            btConfirmForwardingAdress.Click();

            driver.SwitchTo().Window(currentHandle);
            btnConfirmForwardingOK.Click();
             
        }



        public void SetForwardCopyTo()
        {
            rbtnFrowardCopyTo.Click();
        }


    }
}
