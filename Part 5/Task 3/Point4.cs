using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task_3
{
    class Point4
    {

        public static IEnumerable<IGrouping<string, string>> GetAnswer(XDocument doc)
        {

            var customers =
                from customer in doc.Root.Elements("customer")
                from order in customer.Element("orders").Elements("order")
                orderby DateTime.Parse(order.Element("orderdate").Value)
                group order.Element("orderdate") .Value by customer.Element("name").Value;

            return customers;

        }


    }
}
