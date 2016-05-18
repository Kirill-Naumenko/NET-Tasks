using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSTest;
using MSTestMethods;
using System.Threading;
using System.Data;

namespace MSTest
{
    [TestClass]
    public class MSTestBrowser : BaseTestClass
    {

        //public TestContext TestContext { get; set; }
        private TestContext testContextInstance;
        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }
        Browser browser;

        [TestMethod, DeploymentItem(@"C:\Users\Kiryl_Navumenka@epam.com\WS\Testing\MSTest\DataSource.xml")]
        [TestCategory("smoke")]
        [Timeout(25000)]
        [Description("Test for open")]
        [Owner("Kirill")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\DataSource.xml", "url", DataAccessMethod.Sequential)]
        public void TestOpen()
        {
          
            string url = (string)TestContext.DataRow["path"];
            string actual = browser.Open(url);
            string expected = (string)TestContext.DataRow["result"];
            Assert.AreEqual(expected, actual);

        }


        [TestMethod]
        [TestCategory("smoke")]
        [Timeout(10000)]
        [Description("Test for close")]
        [Owner("Kirill")]
        [Ignore]
        public void TestClose()
        {
            
            bool actual = browser.Close();
            bool expected = true;
            Assert.AreEqual(expected, actual);

        }

        

        [TestMethod]
        [TestCategory("daily")]
        [Timeout(1)]
        [Description("Test for MoveToUrl")]
        [Owner("Kirill")]
        [Ignore]
        public void TestMoveToUrl()
        {
            
            string actual = browser.MoveToUrl("https://www.epam.com/solutions");
            string expected = "https://www.epam.com/solutions";
            Assert.AreEqual(expected, actual);

        }


        [TestMethod]
        [TestCategory("daily")]
        [Timeout(10000)]
        [Description("Test for exeption")]
        [Owner("Kirill")]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestForExeption()
        {  
            browser.ThrowExeption();
        }


        //======================================================================

        [ClassInitialize]
        public static void ClassInitialize(TestContext cont)
        {

            BaseClassInitialize(cont);
            Logger log = new Logger();
            log.Write("Class Initialize");
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            
            Logger log = new Logger();
            log.Write("Class Cleanup");
            BaseClassCleanup();
        }

        

        [TestInitialize]
        public void TestInitialize()
        { 
            browser = new Browser();
            Logger log = new Logger();
            log.Write("Test Initialize");
            log.Write("=============="+ TestContext.TestName);
        }

        [TestCleanup]
        public void TestCleanup()
        {
           
            Logger log = new Logger();
            log.Write("Test Cleanup");
        }


    }
}
