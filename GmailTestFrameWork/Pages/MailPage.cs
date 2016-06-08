using Driver;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Pages
{
    public class MailPage : BasePage
    {

        public const string BASE_URL = "https://mail.google.com/mail/u/0/#inbox";

        [FindsBy(How = How.XPath, Using = "//div[contains(@class, 'T-I') and contains(@class ,'T-I-KE')]")]
        private IWebElement buttonWriteMessage { get; set; }

        [FindsBy(How = How.Name, Using = "to")]
        private IWebElement textfieldReceiverName { get; set; }
        [FindsBy(How = How.Name, Using = "subjectbox")]
        private IWebElement textfieldSubjectName { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[contains(@class, 'editable') and contains(@class ,'LW-avf')]")]
        private IWebElement textfieldTextMessage { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[contains(@class, 'aoO') and contains(@class ,'T-I-atl')]")]
        private IWebElement buttonSendLetter { get; set; } 

        [FindsBy(How = How.XPath, Using = "//span[contains(@class,'gb_3a')]")]
        private IWebElement buttonProfile { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[contains(@href, 'Logout')]")]
        private IWebElement buttonExitProfile { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(@href,'#inbox')]")]
        private IWebElement buttonInbox { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[contains(@href,'#spam')]")]
        private IWebElement buttonSpam { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(@class, 'CJ')]")]
        private IWebElement buttonDropDownMenu { get; set; }

        public MailPage(IWebDriver driver) : base(driver)
        {

        }

        public MailPage Open()
        {
            driver.Navigate().GoToUrl(BASE_URL);
            return new MailPage(driver);
        }

        public GoogleMainPage LogOut()
        {
            buttonProfile.Click();
            buttonExitProfile.Click();
            if (isAlertPresent())
            {
                driver.SwitchTo().Alert().Accept();
            }
            return new GoogleMainPage(driver).Open();
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

        public MailPage SendMessage(Message message)
        {
            buttonWriteMessage.Click();
            textfieldReceiverName.SendKeys(message.receiver);
            textfieldSubjectName.SendKeys(message.subject);
            textfieldTextMessage.SendKeys(message.text);
            buttonSendLetter.Click();
            return new MailPage(driver);
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

        public MailPage PutMessageToSpam()
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
            return new MailPage(driver);
        }

        public MailPage GoToSpamFolder()
        {
            buttonDropDownMenu.Click();
            buttonSpam.Click();
            return new MailPage(driver);
        }

        public MailPage GetDropDownMenu()
        {
            buttonDropDownMenu.Click();
            return new MailPage(driver);
        }
    }
}