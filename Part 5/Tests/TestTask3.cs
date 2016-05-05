using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Xml.Linq;
using Task_3;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;

namespace Tests
{
    [TestClass]
    public class TestTask3
    {
        private XDocument doc;

        [TestInitialize]
        public void Initialize()
        {
            doc = XDocument.Load(ConfigurationManager.AppSettings["TestPath"]);
        }


        [TestMethod]
        public void Point1XML()
        {

            
            int money = 4000;

            var actual = from customer in Point1.GetAnswer(doc, money)
                         select customer.Element("id").Value;

            Assert.IsTrue(actual.First().Equals("ALFKI"));
        }

        [TestMethod]
        public void Point2XML()
        {

           
            Assert.IsTrue((Point2.GetAnswer(doc).First().Key).Contains("Germany"));
        }

        [TestMethod]
        public void Point3XML()
        {

           
            int money = 2000;

            var actual = from customer in Point3.GetAnswer(doc, money)
                         select customer.Element("id").Value;

            Assert.IsTrue(actual.First().Equals("COMMI"));
        }

        [TestMethod]
        public void Point4XML()
        {

            

            var actual = Point4.GetAnswer(doc).First().Value.ToString();

            Assert.IsTrue(Point4.GetAnswer(doc).First().Value.ToString().Equals("8/25/1997 12:00:00 AM"));
        }

        [TestMethod]
        public void Point5XML()
        {



            var actual = Point5.GetAnswer(doc).First().Element("id").Value;


            Assert.IsTrue(actual.Equals("COMMI"));
        }

        [TestMethod]
        public void Point6XML()
        {


            var actual = Point6.GetAnswer(doc).First().Element("id").Value;

            Assert.IsTrue(actual.Equals("ALFKI"));
        }

        [TestMethod]
        public void Point7_1XML()
        {

          
            var actual = Point7_1.GetAnswer(doc).Last().Value;
            double expected = 1160.4375;

            Assert.IsTrue(Math.Round((double)actual,2) == Math.Round(expected, 2));
        }

        [TestMethod]
        public void Point7_2XML()
        {


            //var actual = Point7_2.GetAnswer(doc);
            //double expected = 6;

         

            ////Assert.IsTrue(actual == expected);
        }




    }

    
}
