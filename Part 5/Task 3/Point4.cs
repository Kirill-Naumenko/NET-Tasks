using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task_3
{
    public class Point4
    {

        //public static IDictionary<string, XElement>GetAnswer(XDocument doc)
        //{

        //    var customers = (from cust in doc.Descendants("customer")
        //                     let orders = cust.Element("orders").Elements("order").ToList()
        //                     where orders.Count > 0
        //                     let firstOrder = orders.Min(order => DateTime.Parse(order.Element("orderdate").Value))
        //                     group firstOrder by cust.Element("name");

        //    return customers;

        //}

        public static IDictionary<string, DateTime> GetAnswer(XDocument doc)
        {
            var customers = (from cust in doc.Descendants("customer")
                             let orders = cust.Element("orders").Elements("order").ToList()
                             where orders.Count > 0
                             let firstOrder = orders.Min(order => DateTime.Parse(order.Element("orderdate").Value))
                             select new
                             {key = cust.Element("name").Value,  value = firstOrder }).ToDictionary(o => o.key, o => o.value);

            return customers;
        }


    }
}
