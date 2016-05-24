﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pages.SettingsPage
{
    public class SettingsMenu
    {
        private IWebDriver driver;

        [FindsBy(How = How.XPath, Using = "//a[contains(@href,'fwdandpop')]")]
        public IWebElement insetForwardingSettings { get; set; }


        public SettingsMenu(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }

        public void GoToForwardingSettings()
        {
            insetForwardingSettings.Click();
        }

    }
}