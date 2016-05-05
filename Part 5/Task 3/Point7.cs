using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task_3
{
    class Point7
    {



        public static void GetAnswer(XDocument doc)
        {

            var profitability =
               (from customer in doc.Element("customers").Elements("customer")
               from order in customer.Element("orders").Elements("order")
               group order by customer.Element("city").Value into AverageByCity
               select new
               {
                   city = AverageByCity.Key,
                   average = AverageByCity.Average(avr => decimal.Parse((string)avr.Element("total")))
               }).ToDictionary(t=>t.city, t=>t.average);


            //foreach (var info in profitability)
            //{
            //    Console.WriteLine("City : " + info.city);

            //    Console.WriteLine("\t Average profitability " + Math.Round(info.average,3) +"\r\n");
            //}

            //Console.WriteLine("\r\n");



            



                


            var countOfOrdersByCustomer = (from customer in doc.Element("customers").Elements("customer")
                                   from order in customer.Element("orders").Elements("order")
                                   select new
                                   {
                                       customer = customer.Element("id").Value,
                                       orders = order
                                   }).ToDictionary(t => t.customer, t => t.orders.ToString().Count());





            //var summOfOrdersByCity =
            //       from customer in doc.Element("customers").Elements("customer")
            //       from order in customer.Element("orders").Elements("order")
            //       group order by customer.Element("city").Value into summ
            //       select new
            //       {
            //           city = summ.Key,
            //           summary = summ.Average(sum => decimal.Parse((string)sum.Element("total"))),
                   
            //       };

            //foreach (var info in summOfOrdersByCity)
            //{
            //    Console.WriteLine("City : " + info.city);
            //    Console.WriteLine("\t Average intensity " + Math.Round(info.summary/countOfOrdersByCity.Count(), 3) + "\r\n");
            //}







        }

    }
}
