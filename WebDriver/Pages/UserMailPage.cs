using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading;
using OpenQA.Selenium.Interactions;
using Drivers;
using OpenQA.Selenium.Remote;

namespace Pages
{
    public class UserMailPage
    {


        public const string BASE_URL = "https://mail.google.com/mail/u/0/#inbox";
        private IWebDriver driver;

        [FindsBy(How = How.XPath, Using = "//div[contains(@class, 'T-I') and contains(@class ,'T-I-KE')]")]
        private IWebElement btnWriteMessage  { get; set; }

        [FindsBy(How = How.Name, Using = "to")]
        private IWebElement tfReceiverName { get; set; }
        [FindsBy(How = How.Name, Using = "subjectbox")]
        private IWebElement tfSubjectName { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[contains(@class, 'editable') and contains(@class ,'LW-avf')]")]
        private IWebElement tfTextMessage { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[contains(@class, 'aoO') and contains(@class ,'T-I-atl')]")]
        private IWebElement btnSendLetter { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(@class,'gb_3a')]")]
        private IWebElement btnProfile { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[contains(@href, 'Logout')]")]
        private IWebElement btnExitProfile { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(@href,'#inbox')]")]
        private IWebElement btnInbox { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[contains(@href,'#spam')]")]
        private IWebElement btnSpam { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(@class, 'aos')]")]
        private IWebElement btnSettingsMenu { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[contains(@class, 'aMS')]")]
        public IWebElement btnSettings { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(@class, 'CJ')]")]
        private IWebElement btnDropDownMenu { get; set; }

        [FindsBy(How = How.XPath , Using = "//a[contains(@href, 'https://mail-settings.google.com/mail/vf')]")]
        private IWebElement lkConfirmationForwarding { get; set; }
        [FindsBy(How =How.XPath,Using ="//input[contains(@type,'submit')]")]
        public IWebElement btnSubmitforwarding { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'aMZ') and contains(@class,'aA7')]")]
        public IWebElement tfAttach { get; set; }
        [FindsBy(How = How.XPath,Using ="//span[contains(text(),'attach')]")]
        public IWebElement btnFile { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'a-b-c') and contains(@class,'d-u-F')]")]
        public IWebElement btnInsert { get; set; }

        public UserMailPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }
        //=====================================TESTCASE 1========================================================
        public void Open()
        {
            driver.Navigate().GoToUrl(BASE_URL);
        }

        public void LogOut()
        {
            btnProfile.Click();
            btnExitProfile.Click();
            if (isAlertPresent())
            {
                driver.SwitchTo().Alert().Accept();
            }

        }

        public void GetSettingsMenu()
        {
            //btnSettingsMenu.Click();
            new Actions(driver).MoveToElement(btnSettingsMenu).ClickAndHold().MoveToElement(btnSettings).Release().Perform();
            //new Actions(driver).DragAndDrop(btnSettingsMenu, btnSettings).Click().Perform();
            //btnSettings.Click();
            //driver.Navigate().GoToUrl("https://mail.google.com/mail/u/0/#settings/general");         
        }

        public void SendMessage(Message message)
        {         
            btnWriteMessage.Click();
            tfReceiverName.SendKeys(message.receiver);
            tfSubjectName.SendKeys(message.subject);
            tfTextMessage.SendKeys(message.text);
            if (message.Attacment)
            {
                //Хардкод
                var currentHandle = driver.CurrentWindowHandle;
                tfAttach.Click();
                var handles = driver.WindowHandles;
                foreach (var handle in handles)
                {
                    driver.SwitchTo().Window(handle);
                }
                btnFile.Click();
                btnInsert.Click();
                driver.SwitchTo().Window(currentHandle); 
            }
            btnSendLetter.Click(); 
        }  
        

        public bool SelectMessageBySubject(string subject)
        {
            if (driver.FindElement(By.XPath($"//span[contains(text(),'{subject}')]")).Displayed)
            {
                driver.FindElement(By.XPath($"//span[contains(text(),'{subject}')]")).Click();
                return true;
            }
            return false;
        }

        public void PutMessageToSpam()
        {
            // !!!!!!ОСТОРОЖНО ГОВНОКОД xPath
            var currentHandle = driver.CurrentWindowHandle;
            driver.FindElement(By.XPath("//div[2]/div/div/div[2]/div[2]/div/div")).Click();   
            var handles = driver.WindowHandles;
            foreach (var handle in handles)
            {
                driver.SwitchTo().Window(handle);
            }
            driver.FindElement(By.Name("rs")).Click();
            driver.SwitchTo().Window(currentHandle);
        }

        public void ToSpamFolder()
        {
            btnDropDownMenu.Click();
            btnSpam.Click();
        }

        public void GetDropDownMenu()
        {
            btnDropDownMenu.Click();
        }

        public bool isAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

//=========================TESTCASE 2=================================================================

        public void ConfirmForwarding()
        {
            lkConfirmationForwarding.Click();
            var currentHandle = driver.CurrentWindowHandle;
            var handles = driver.WindowHandles;
            foreach (var handle in handles)
            {
                driver.SwitchTo().Window(handle);
            }
            btnSubmitforwarding.Click();
            driver.Close();
            driver.SwitchTo().Window(currentHandle);          
        }
    }
}
