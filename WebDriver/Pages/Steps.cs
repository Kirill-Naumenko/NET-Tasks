using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Pages.SettingsPage;
using Drivers;

namespace Pages
{
    public class Steps
    {

        private IWebDriver driver;


        public Steps(IWebDriver driver)
        {
            this.driver = driver;
        }


        public void LoginAsUser(string login, string password)
        {
            StartPage StartPage = new StartPage(driver);
            StartPage.Open();
            SignInPage SignInPage = new SignInPage(driver);
            SignInPage.Open();
            SignInPage.LogIn(login, password);
            UserMailPage UserMailPage = new UserMailPage(driver);
            UserMailPage.Open();
        }

        public void SendMessage(Message message)
        {
            UserMailPage UserMailPage = new UserMailPage(driver);
            UserMailPage.SendMessage(message);
        }

        public void LogOut()
        {
            UserMailPage UserMailPage = new UserMailPage(driver);
            UserMailPage.LogOut();
        }

        public void MarkLetterAsSpam(string subject)
        {
            UserMailPage UserMailPage = new UserMailPage(driver);
            UserMailPage.SelectMessageBySubject(subject);
            UserMailPage.PutMessageToSpam();
        }

        public bool CheckSpamFolder(string subject)
        {
            UserMailPage UserMailPage = new UserMailPage(driver);
            UserMailPage.ToSpamFolder();
            bool result = UserMailPage.SelectMessageBySubject(subject);
            return result;
        }

        //=========================================================

        public void SetForwardingToUser(string login)
        {
            UserMailPage UserMailPage = new UserMailPage(driver);
            UserMailPage.Open();
            //Go to settings menu
            UserMailPage.GetSettingsMenu();

            SettingsMenu SettingsMenu = new SettingsMenu(driver);
            //Go to forwarding settings and set forward to user3
            SettingsMenu.GoToForwardingSettings();
            ForwardSettingsPage forwardSettingsPage = new ForwardSettingsPage(driver);
            forwardSettingsPage.SetForwardUser(login);
            UserMailPage.Open();
            UserMailPage.LogOut();
        }

        public void ConfirmForwardingFrom(string login)
        {
            UserMailPage UserMailPage = new UserMailPage(driver);
            UserMailPage.SelectMessageBySubject(login);
            UserMailPage.ConfirmForwarding();
            UserMailPage.LogOut();
        }

        public void EndoOfSettingForwarding()
        {
            UserMailPage UserMailPage = new UserMailPage(driver);
            SettingsMenu SettingsMenu = new SettingsMenu(driver);
            ForwardSettingsPage forwardSettingsPage = new ForwardSettingsPage(driver);
            UserMailPage.Open();
            UserMailPage.GetSettingsMenu();
            SettingsMenu.GoToForwardingSettings();
            forwardSettingsPage.SetForwardCopyTo();
        }

        public void CreateNewFilter(Filter filter)
        {            
            UserMailPage UserMailPage = new UserMailPage(driver);
            UserMailPage.Open();
            UserMailPage.GetSettingsMenu();
            SettingsMenu SettingsMenu = new SettingsMenu(driver);
            SettingsMenu.GoToFilterSettings();
            FiltersSettingsPage filterSettingsPage = new FiltersSettingsPage(driver);       
            filterSettingsPage.CreateNewFilter(filter);           
        }
        




    }
}
