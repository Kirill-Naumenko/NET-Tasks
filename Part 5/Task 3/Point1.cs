using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task_3
{
    public class Point1
    {

        public static IEnumerable<XElement> GetAnswer(XDocument doc, int money)
        {
            
            var customers =
                  from customer in doc.Root.Elements()
                  from orders in customer.Elements("orders")
                  where orders.Elements("order").Sum(sum => decimal.Parse(sum.Element("total").Value)) > money
                  select customer;

            return customers;

        }


    }
}
