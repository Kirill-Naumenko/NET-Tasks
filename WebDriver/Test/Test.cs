using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pages;
using Drivers;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using Pages.SettingsPage;
using System.Xml.Linq;
using System.Linq;

namespace Test
{
    [TestClass]
    public class Test
    {
        IWebDriver driver;

        //Не забыть исправить хардкод
        User User1 = new User("naumenkoyser1@gmail.com", "timefordeath"); //Забанены
        User User2 = new User("naumenkouser2@gmail.com", "timefordeath"); //Забанены
        User User3 = new User("naumenkouser3@gmail.com", "timefordeath"); //Забанены
        User User4 = new User("naumenkouser4@gmail.com", "timefordeath");
        User User5 = new User("naumenkouser5@gmail.com", "timefordeath");
        Message message1 = new Message("АКЦИЯ!!!!! УВЕЛИЧИТЬ ЧЛЕН на 100 метров БЕСПЛАТНО БЕЗ СМС И РЕГИСТРАЦИИ");
        Message message2 = new Message("АКЦИЯ!!!!!");
     

        [TestInitialize]
        public void SetUp()
        {
            driver = WebDriver.GetDriver();
            this.driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
        }

        [TestCleanup]
        public void CleanUp()
        {
            //driver.Quit();
        }

        

        [TestMethod]
        public void TestCase1()
        {
            
            //Sending message to User2
            StartPage StartPage = new StartPage(driver);
            StartPage.Open();
            SignInPage SignInPage = new SignInPage(driver);
            SignInPage.Open();
            SignInPage.LogIn(User4.login, User4.password);
            UserMailPage UserMailPage = new UserMailPage(driver);
            UserMailPage.Open();
            UserMailPage.SendMessage(User5.login,message1.Text, message1.Text);
            UserMailPage.LogOut();

            //Login as user2 and pull message from user1 to spam 
            SignInPage.LogIn(User5.login, User5.password);
            UserMailPage.Open();
            UserMailPage.SelectMessageBySubject(message1.Text);
            UserMailPage.PutMessageToSpam();
            UserMailPage.LogOut();

            //Sending message to User2 again
            SignInPage.LogIn(User4.login, User4.password);
            UserMailPage.Open();
            UserMailPage.SendMessage(User5.login, message2.Text, message2.Text);
            UserMailPage.LogOut();

            //Checking spam
            SignInPage.LogIn(User5.login, User5.password);
            UserMailPage.Open();
            UserMailPage.ToSpamFolder();
            
            Assert.IsTrue(UserMailPage.SelectMessageBySubject(message2.Text));
           


        }

        [TestMethod]
        public void TestCase2()
        {
            StartPage StartPage = new StartPage(driver);
            StartPage.Open();
            SignInPage SignInPage = new SignInPage(driver);
            SignInPage.Open();

            //Login as user 2
            SignInPage.LogIn(User5.login,User5.password);
            UserMailPage UserMailPage = new UserMailPage(driver);
            UserMailPage.Open();
            //Go to settings menu
            UserMailPage.GetSettingsMenu();
            
            SettingsMenu SettingsMenu = new SettingsMenu(driver);
            //Go to forwarding settings and set forward to user3
            SettingsMenu.GoToForwardingSettings();
            ForwardSettingsPage forwardSettingsPage = new ForwardSettingsPage(driver);
            forwardSettingsPage.SetForwardUser(User4.login);
            UserMailPage.Open();
            UserMailPage.LogOut();

            SignInPage.LogIn(User4.login, User4.password);
            UserMailPage.SelectMessageBySubject(User5.login);
            UserMailPage.ConfirmForwarding();
            UserMailPage.LogOut();

            SignInPage.LogIn(User5.login, User5.password);
            UserMailPage.Open();
            UserMailPage.GetSettingsMenu();
            SettingsMenu.GoToForwardingSettings();
            forwardSettingsPage.SetForwardCopyTo();


        }

    }
}
