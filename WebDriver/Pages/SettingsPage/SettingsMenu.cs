using OpenQA.Selenium;
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
        public IWebElement tabForwardingSettings { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(@href,'filters')]")]
        public IWebElement tabFilterSettings { get; set; }


        public SettingsMenu(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }

        public void GoToForwardingSettings()
        {
            tabForwardingSettings.Click();
        }

        public void GoToFilterSettings()
        {
            tabFilterSettings.Click();
        }

    }
}
