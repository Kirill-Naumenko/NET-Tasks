using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pages;
using Drivers;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using Pages.SettingsPage;

namespace Test
{
    [TestClass]
    public class Test
    {
        User User1 = new User("naumenkoyser1@gmail.com", "timefordeath");
        User User2 = new User("naumenkouser2@gmail.com", "timefordeath");
        User User3 = new User("naumenkoyser3gmail.com", "timefordeath");
        private string LoginUser1 = "naumenkoyser1@gmail.com";
        private string PasswordUser1 = "timefordeath";
        private string LoginUser2 = "naumenkouser2@gmail.com";
        private string PasswordUser2 = "timefordeath";
        private string LoginUser3 = "naumenkouser3@gmail.com";
        private string PasswordUser3 = "timefordeath";
        private string MessageSubject = "АКЦИЯ!!!!! УВЕЛИЧИТЬ ЧЛЕН на 100 метров БЕСПЛАТНО БЕЗ СМС И РЕГИСТРАЦИИ";
        private string MessageSubject1 = "АКЦИЯ!!!!!";

        IWebDriver Driver = WebDriver.GetDriver();

        [TestMethod]
        public void TestCase1()
        {

            //Sending message to User2
            StartPage StartPage = new StartPage(Driver);
            StartPage.Open();
            SignInPage SignInPage = new SignInPage(Driver);
            SignInPage.Open();
            SignInPage.LogIn(User1.login, User1.password);
            UserMailPage UserMailPage = new UserMailPage(Driver);
            UserMailPage.Open();
            UserMailPage.SendMessage(User2.login,MessageSubject,MessageSubject);
            UserMailPage.LogOut();

            //Login as user2 and pull message from user1 to spam 
            SignInPage.LogIn(User2.login, User2.password);
            UserMailPage.Open();
            UserMailPage.SelectMessageBySubject(MessageSubject);
            UserMailPage.PutMessageToSpam();
            UserMailPage.LogOut();

            //Sending message to User2 again
            SignInPage.LogIn(User1.login, User1.password);
            UserMailPage.Open();
            UserMailPage.SendMessage(User1.login, MessageSubject1, MessageSubject1);
            UserMailPage.LogOut();

            //Checking spam
            SignInPage.LogIn(User2.login, User2.password);
            UserMailPage.Open();
            UserMailPage.ToSpamFolder();

            Assert.IsTrue(UserMailPage.SelectMessageBySubject(MessageSubject1));

            Driver.Close();

        }

        [TestMethod]
        public void TestCase2()
        {
            StartPage StartPage = new StartPage(Driver);
            StartPage.Open();
            SignInPage SignInPage = new SignInPage(Driver);
            SignInPage.Open();
            SignInPage.LogIn(User2.login,User2.password);
            UserMailPage UserMailPage = new UserMailPage(Driver);
            UserMailPage.Open();
            UserMailPage.GetSettingsMenu();
            SettingsMenu SettingsMenu = new SettingsMenu(Driver);
            SettingsMenu.btnSettings.c
        }

    }
}
