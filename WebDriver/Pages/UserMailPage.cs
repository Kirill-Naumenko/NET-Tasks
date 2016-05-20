using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Pages
{
    public class UserMailPage
    {


        public const string Base_Url = "https://mail.google.com/mail/u/0/#inbox";
        private IWebDriver driver;

        public UserMailPage(IWebDriver driver)
        {
            this.driver = driver;
            this.driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
            PageFactory.InitElements(this.driver, this);
        }

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

        [FindsBy(How = How.XPath, Using = "//span[contains(@class,'gb_2a')]")]
        private IWebElement btnProfile { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[contains(@href, 'Logout')]")]
        private IWebElement btnExitProfile { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(@href,'#inbox')]")]
        private IWebElement btnInbox { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[contains(@href,'#spam')]")]
        private IWebElement btnSpam { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(@class, 'aos')]")]
        private IWebElement btnSettingsMenu { get; set; }
        [FindsBy(How = How.ClassName, Using = "J-N-Jz")]
        public IWebElement btnSettings { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(@class, 'CJ')]")]
        private IWebElement btnDropDownMenu { get; set; }


        public void Open()
        {
            driver.Navigate().GoToUrl(Base_Url);
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


        public void GetSettingsMenu()
        {
            btnSettingsMenu.Click();
            btnSettings.Click();
        }

        public void SendMessage(string receiver, string subject, string message)
        {
           
            btnWriteMessage.Click();
            tfReceiverName.SendKeys(receiver);
            tfSubjectName.SendKeys(subject);
            tfTextMessage.SendKeys(message);
            btnSendLetter.Click();

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
            driver.FindElement(By.XPath("//div[2]/div/div/div[2]/div[2]/div/div")).Click(); 
        }

        public void GetDropDownMenu()
        {
            btnDropDownMenu.Click();
        }

        public void ToSpamFolder()
        {
            btnDropDownMenu.Click();
            btnSpam.Click();
        }

    }
}
