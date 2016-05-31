using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pages;
using Drivers;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using Pages.SettingsPage;
using System.Xml.Linq;
using System.Linq;
using OpenQA.Selenium.Support.UI;
using log4net;
using log4net.Config;

namespace Test
{
    [TestClass]
    public class Test
    {
        IWebDriver driver;
        static TestContext context;
        public static readonly ILog log = LogManager.GetLogger(typeof(Test));
        //Не забыть исправить хардкод

        User User1 = new User("naumenkouser4@gmail.com", "timefordeath");
        User User2 = new User("naumenkouser5@gmail.com", "timefordeath");
        User User3 = new User("naumenkouser6@gmail.com", "timefordeath");
        //Message message1 = new Message("АКЦИЯ!!!!! УВЕЛИЧИТЬ ЧЛЕН на 100 метров БЕСПЛАТНО БЕЗ СМС И РЕГИСТРАЦИИ");
        //Message message2 = new Message("АКЦИЯ!!!!!");
        static Random random = new Random();
        Message message1 = new Message("naumenkouser6@gmail.com", random.Next(0,100000).ToString());
        Message message2 = new Message("naumenkouser6@gmail.com", random.Next(0, 1050).ToString());
        Message messageWithAttachment = new Message("naumenkouser5@gmail.com","With Attacment", true);
        Message messageWithNoAttachment = new Message("naumenkouser5@gmail.com", "With no Attacment");

        Filter filter = new Filter("naumenkouser4@gmail.com");
        

        [ClassInitialize]
        public static void ClassSetUp(TestContext c)
        {
            context = c;
            DOMConfigurator.Configure();
        }

        [TestInitialize]
        public void SetUp()
        {    
            driver = WebDriver.GetDriver();
            this.driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
        }

        [TestCleanup]
        public void CleanUp()
        {
            if(context.CurrentTestOutcome == UnitTestOutcome.Error)
            {
                log.Info(context.TestName + " failed");
            }
            if (context.CurrentTestOutcome == UnitTestOutcome.Passed)
            {
                log.Info(context.TestName + " passed");
            }
  
            //driver.Quit();
        }

        

        [TestMethod]
        public void TestCase1()
        {

            Steps step = new Steps(driver);
            step.LoginAsUser(User2.login, User2.password);
            step.SendMessage(message1);
            step.LogOut();
            step.LoginAsUser(User3.login, User3.password);
            step.MarkLetterAsSpam(message1.text);
            step.LogOut();
            step.LoginAsUser(User2.login, User2.password);
            step.SendMessage(message2);
            step.LogOut();
            step.LoginAsUser(User3.login, User3.password);
            bool actualResult = step.CheckSpamFolder(message2.text);

            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void TestCase2()
        {
            //filter.attachment = true;
            //filter.deleteIt = true;
            //filter.markAsimportant = true;

            Steps step = new Steps(driver);
            //step.LoginAsUser(User2.login, User2.password);
            //step.SetForwardingToUser(User1.login);
            //step.LoginAsUser(User1.login, User1.password);
            //step.ConfirmForwardingFrom(User2.login);
            //step.LoginAsUser(User2.login, User2.password);
            //step.EndoOfSettingForwarding();
            //step.CreateNewFilter(filter);
            //step.LogOut();
            step.LoginAsUser(User1.login, User1.password);
            step.SendMessage(messageWithAttachment);
            //IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            //js.ExecuteScript("return $('input').show()");
            //step.SendMessageToUser(User2.login, messageWithAttachment.Text, messageWithAttachment.Text);
            //***************************

            //*****************************
            Assert.IsTrue(false);
        }

    }
}
