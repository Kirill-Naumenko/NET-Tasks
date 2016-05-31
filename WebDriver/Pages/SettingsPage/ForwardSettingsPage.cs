using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Pages.SettingsPage
{
    public class ForwardSettingsPage
    {
        private IWebDriver driver;       

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
        
        [FindsBy(How = How.XPath, Using = "//input[contains(@name,'sx_em') and contains(@value,'1')] ")]
        public IWebElement rbtnFrowardCopyTo { get; set; }
        //[FindsBy(How = How.XPath, Using = "//div[@role='main']//tr[@guidedhelpid='save_changes_row']//button[@guidedhelpid]")]
        //[FindsBy(How = How.XPath, Using = "//button[(contains(@guidedhelpid,'save_changes_button')) and not(contains(@disabled,''))]")]
        //button[contains(@guidedhelpid,'save_changes_button')]
        [FindsBy(How = How.XPath, Using = "//div[@class='nH Tv1JD']//button[@guidedhelpid='save_changes_button']")]
        public IWebElement btnSaveChanges { get; set; }
     
        public ForwardSettingsPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }

        public void SetForwardUser(string login)
        {
            Trace.WriteLine("");
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
            if (rbtnFrowardCopyTo.Displayed)
            {
                rbtnFrowardCopyTo.Click();
            }
            if (btnSaveChanges.Displayed)
            {
                btnSaveChanges.Click();
                Thread.Sleep(3000); // !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            }
            else
            {
                throw new DivideByZeroException();
            }
             
        }
    }
}
