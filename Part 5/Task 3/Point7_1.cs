using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task_3
{
   public class Point7_1
    {

        public static Dictionary<string, decimal>   GetAnswer(XDocument doc)
        {

            var profitability =
               (from customer in doc.Element("customers").Elements("customer")
                from order in customer.Element("orders").Elements("order")
                group order by customer.Element("city").Value into AverageByCity
                select new
                {
                    city = AverageByCity.Key,
                    average = AverageByCity.Average(avr => decimal.Parse((string)avr.Element("total")))
                }).ToDictionary(t => t.city, t => t.average);

            return profitability;
        }
    }
}
