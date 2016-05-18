using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSTestMethods;

namespace MSTest
{

    
    [TestClass]
    public class BaseTestClass
    {
       


        [ClassInitialize]
        public static void BaseClassInitialize(TestContext cont)
        {
            
            Logger log = new Logger();
            log.Write("Base Class Initialize");
        }

        [ClassCleanup]
        public static void BaseClassCleanup()
        {
            Logger log = new Logger();
            log.Write("Base Class Cleanup");
        }

        [TestInitialize]
        public void BaseTestInitialize()
        {
          
            Logger log = new Logger();
            log.Write("Base Test Initialize");
            
        }

        [TestCleanup]
        public void BaseTestCleanup()
        {
            Logger log = new Logger();
            log.Write("Base Test Cleanup");  
        }

       


    }
}
