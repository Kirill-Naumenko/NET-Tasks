using Drivers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pages.SettingsPage
{
    public class FiltersSettingsPage
    {

        private IWebDriver driver;

        [FindsBy(How = How.XPath, Using = "//span[contains(@class ,'sA') and contains(text(),'Create a new filter')]")]
        public IWebElement btnCreateNewFilter { get; set; }

        [FindsBy(How = How.XPath, Using ="//input[contains(@class, 'aQa')]")]
        private IWebElement tfFilterFrom { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'w-Nw')]//label[contains(text(),'Has attachment')]")]
        public IWebElement cbHasAttachments { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'acM')]")]
        public IWebElement btnCreateFilterWithThisSearch {get;set;}

        [FindsBy(How = How.XPath, Using = "//label[contains(@class,'aD') and contains(text(),'Delete')]")]
        public IWebElement cbDeleteIt { get; set; }
        [FindsBy(How = How.XPath, Using = "//label[contains(@class,'aD') and contains(text(),'Always')]")]
        public IWebElement cbAlwaysMarkAsImportant { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'T-I') and  contains(text(),'Create')]")]
        public IWebElement btnSaveFilter { get; set; }

        public FiltersSettingsPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }

        public void CreateNewFilter(Filter filter)
        {
            btnCreateNewFilter.Click();  
            tfFilterFrom.SendKeys(filter.from);

            if (filter.attachment == true)
            {
                cbHasAttachments.Click();
            }

            btnCreateFilterWithThisSearch.Click();

            if (filter.deleteIt == true)
            {
                cbDeleteIt.Click();
            }

            if (filter.markAsimportant == true)
            {
                cbAlwaysMarkAsImportant.Click();
            }
          
            btnSaveFilter.Click();
        }
    }
}
