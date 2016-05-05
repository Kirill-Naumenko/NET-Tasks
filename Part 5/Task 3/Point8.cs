using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task_3
{
    class Point8
    {


        public static void GetAnswer(XDocument doc)
        {
            

            
            var averagePerYear =  (from f in doc.Element("customers").Elements("customer")
                     from k in f.Elements("orders").Elements("order")
                     let date = DateTime.Parse(k.Element("orderdate").Value).Year 
                     group decimal.Parse(k.Element("total").Value) by date into perYear
                     select new   
                     {
                         year = perYear.Key,
                         average = perYear.Average()
                     }).ToDictionary(d => d.year, d => d.average);

            foreach (var cust in averagePerYear)
            {
                Console.Write($" Year " + cust.Key + "\t" + " Average  " + Math.Round(cust.Value,2) + "\r\n");

            }

            Console.WriteLine("\r\n");






            var averagePerMonth = (from f in doc.Element("customers").Elements("customer")
                                  from k in f.Elements("orders").Elements("order")
                                  let date = DateTime.Parse(k.Element("orderdate").Value).Month
                                  group decimal.Parse(k.Element("total").Value) by date into perMonth
                                  select new
                                  {
                                      month = perMonth.Key,
                                      average = perMonth.Average()
                                  }).ToDictionary(d => d.month, d => d.average);

            foreach (var cust in averagePerMonth)
            {
                Console.Write($" Month " + cust.Key + "\t" + " Average  " + Math.Round(cust.Value, 2) + "\r\n");

            }


            //var averagePerMonthYear = (from f in doc.Element("customers").Elements("customer")
            //                           from k in f.Elements("orders").Elements("order")
            //                           let dateYear = DateTime.Parse(k.Element("orderdate").Value).Year
            //                           let dateMonth = DateTime.Parse(k.Element("orderdate").Value).Month
            //                           group decimal.Parse(k.Element("total").Value) by dateMonth into perMonth
            //                           select new
            //                           {
            //                               month = perMonth.Key,
            //                               average = perMonth.Average()
            //                           }).ToDictionary(d => d.month, d => d.average);



        }




    }
}
