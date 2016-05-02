using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
           

            XDocument doc = XDocument.Load(ConfigurationManager.AppSettings["path"]);



            //Console.WriteLine("Пунк 1 : Выдайте список всех клиентов, чей суммарный оборот (сумма всех заказов) превосходит некоторую величину X ");
            int money = 10000;
            //foreach (var customers in Point1.GetAnswer(doc, money))
            //{
            //    Console.WriteLine($"Customer: {(string)customers.Element("name")}");
            //}



            //Console.WriteLine("\r\n");



            //Console.WriteLine("Пунк 2 : Сгруппировать клиентов по странам ");
            //foreach (var country in Point2.GetAnswer(doc))
            //{
            //    Console.WriteLine(country.Key);
            //    foreach (var customer in country)
            //    {
            //        Console.WriteLine("\t\t" + (string)customer.Element("name"));
            //    }
            //}



            //Console.WriteLine("\r\n");



            //Console.WriteLine("Пунк 3 : Найдите всех клиентов, у которых были заказы, превосходящие по сумме величину X");
            //foreach (var customers in Point3.GetAnswer(doc, money))
            //{
            //    Console.WriteLine($"Customer: {(string)customers.Element("name")}");
            //}



            //Console.WriteLine("\r\n");




            //Console.WriteLine("Пунк 4 : Выдайте список клиентов с указанием, начиная с какого месяца какого года они стали клиентами ");
            //foreach (var cust in Point4.GetAnswer(doc))
            //{
            //    Console.Write($" Customer " + cust.Key + "\t" + " First order in " + cust.Value + "\r\n");

            //}



            //Console.WriteLine("\r\n");



            //Console.WriteLine("Пунк 5 : Сделайте предыдущее задание, но выдайте список отсортированным по году, месяцу, оборотам клиента (от максимального к минимальному) и имени клиента ");

            //foreach (var cust in Point4.GetAnswer(doc))
            //{
            //    Console.Write($" Customer " + cust.Key + "\t" + " First order in " + cust.Value + "\r\n");

            //}

            //foreach (var cust in Point5.GetAnswer(doc))
            //{
            //    Console.Write($" Customer " + (string)cust.Element("name") + "\r\n)");

            //}

            // string custr = (string)Point5.GetAnswer(doc).First().Element("name").Value.ToString();
            //Console.WriteLine(custr);



            //Console.WriteLine("\r\n");



            Console.WriteLine("Пунк 6 : Укажите всех клиентов, у которых указан нецифровой код или не заполнен регион или в телефоне не указан код оператора  ");
            foreach (var t in Point6.GetAnswer(doc))
            {
                Console.WriteLine((string)t.Element("name") + "\r\n\t" + " PHONE " + (string)t.Element("phone"));
                Console.WriteLine((string)t.Element("name") + "\r\n\t" + " CODE " + (string)t.Element("postalcode"));
                Console.WriteLine((string)t.Element("name") + "\r\n\t" + " REGION " + (string)t.Element("region"));
            }


            //Console.WriteLine("\r\n");



            //Console.WriteLine("Пунк 7 : Рассчитайте среднюю прибыльность каждого города (среднюю сумму заказа по всем клиентам из данного города) и среднюю интенсивность (среднее количество заказов, приходящееся на клиента из каждого города)");
            //Point7.GetAnswer(doc);


            Console.ReadKey();



        }
    }

    [TestClass]
    public class TestTask3
    {
        

        [TestMethod]
        public void TestPoint1XML()
        {

            XDocument doc = XDocument.Load(ConfigurationManager.AppSettings["path"]);
            int money = 10000;

            Assert.IsTrue(((string)Point1.GetAnswer(doc, money).First().Element("name")).Equals("Around the Horn"));



        }

        [TestMethod]
        public void TestPoint2XML()
        {
            
            //!!!!!!
            XDocument doc = XDocument.Load(ConfigurationManager.AppSettings["path"]);

            Assert.IsTrue(((string)Point2.GetAnswer(doc).First().Key).Equals("Germany"));



        }

        [TestMethod]
        public void TestPoint3XML()
        {

            XDocument doc = XDocument.Load(ConfigurationManager.AppSettings["path"]);
            int money = 10000;

            Assert.IsTrue(((string)Point3.GetAnswer(doc, money).First().Element("name")).Equals("Hanari Carnes"));


        }

        [TestMethod]
        public void TestPoint4XML()
        {

            XDocument doc = XDocument.Load(ConfigurationManager.AppSettings["path"]);

            var cust = Point4.GetAnswer(doc).First();

            Assert.IsTrue(cust.Value.ToString().Equals("8/25/1997 12:00:00 AM"));



        }

        [TestMethod]
        public void TestPoint5XML()
        {

            XDocument doc = XDocument.Load(ConfigurationManager.AppSettings["path"]);


            var cust = Point5.GetAnswer(doc).First().Element("name").Value.ToString();

            Assert.IsTrue(cust.Equals("Alfreds Futterkiste"));



        }

        [TestMethod]
        public void TestPoint6XML()
        {

            XDocument doc = XDocument.Load(ConfigurationManager.AppSettings["path"]);


            var cust = Point6.GetAnswer(doc).First().Element("name").Value.ToString();

            Assert.IsTrue(cust.Equals("Alfreds Futterkiste"));



        }

    }
}


