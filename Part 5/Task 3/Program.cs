using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
           

            XDocument doc = XDocument.Load(ConfigurationManager.AppSettings["path"]);



            Console.WriteLine("Пунк 1 : Выдайте список всех клиентов, чей суммарный оборот (сумма всех заказов) превосходит некоторую величину X ");
            int money = 10000;
            foreach (var customers in Point1.GetAnswer(doc, money))
            {
                Console.WriteLine($"Customer: {(string)customers.Element("name")}");
            }



            Console.WriteLine("\r\n");



            Console.WriteLine("Пунк 2 : Сгруппировать клиентов по странам ");
            foreach (var country in Point2.GetAnswer(doc))
            {
                Console.WriteLine(country.Key);
                foreach (var customer in country)
                {
                    Console.WriteLine("\t\t" + (string)customer.Element("name"));
                }
            }



            Console.WriteLine("\r\n");



            Console.WriteLine("Пунк 3 : Найдите всех клиентов, у которых были заказы, превосходящие по сумме величину X");
            foreach (var customers in Point3.GetAnswer(doc, money))
            {
                Console.WriteLine($"Customer: {(string)customers.Element("name")}");
            }



            Console.WriteLine("\r\n");




            Console.WriteLine("Пунк 4 : Выдайте список клиентов с указанием, начиная с какого месяца какого года они стали клиентами ");
            foreach (var customers in Point4.GetAnswer(doc))
            {
                Console.WriteLine("name " + customers.Key);
                foreach (var firstOrder in customers)
                {
                    Console.WriteLine("\t\t date " + firstOrder);
                }

            }



            Console.WriteLine("\r\n");



            Console.WriteLine("Пунк 5 : Сделайте предыдущее задание, но выдайте список отсортированным по году, месяцу, оборотам клиента (от максимального к минимальному) и имени клиента ");
            foreach (var customers in Point5.GetAnswer(doc))
            {
                Console.WriteLine("name " + customers.Key);
                foreach (var sort in customers)
                {
                    Console.WriteLine("\t\t date " + sort);
                }

            }



            Console.WriteLine("\r\n");



            Console.WriteLine("Пунк 6 : Укажите всех клиентов, у которых указан нецифровой код или не заполнен регион или в телефоне не указан код оператора  ");
            foreach (var t in Point6.GetAnswer(doc))
            {
                Console.WriteLine((string)t.Element("name") + "\r\n\t" + " PHONE " + (string)t.Element("phone"));
                Console.WriteLine((string)t.Element("name") + "\r\n\t" + " CODE " + (string)t.Element("postalcode"));
                Console.WriteLine((string)t.Element("name") + "\r\n\t" + " REGION " + (string)t.Element("region"));
            }


            Console.WriteLine("\r\n");



            Console.WriteLine("Пунк 7 : Рассчитайте среднюю прибыльность каждого города (среднюю сумму заказа по всем клиентам из данного города) и среднюю интенсивность (среднее количество заказов, приходящееся на клиента из каждого города)");
            Point7.GetAnswer(doc);


            Console.ReadKey();



        }
    }
}
