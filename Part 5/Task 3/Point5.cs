using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task_3
{
    class Point5
    {


        public static IEnumerable<IGrouping<string, string>> GetAnswer(XDocument doc)
        {

            var time = from customer in doc.Root.Elements("customer")
                       from order in customer.Element("orders").Elements("order")
                       select DateTime.Parse(order.Element("orderdate").Value);

            var income = from customer in doc.Root.Elements()
                      from orders in customer.Elements("orders")
                      select orders.Elements("order").Sum(sum => decimal.Parse(sum.Element("total").Value));

            
            var name = from customer in doc.Root.Elements()
                       select customer.Element("name");


            var customers =
                from customer in doc.Root.Elements("customer")
                from order in customer.Element("orders").Elements("order")
                orderby time, income , name descending
                group order.Element("orderdate").Value by customer.Element("name").Value;

            

            return customers;

        }


    }
}
