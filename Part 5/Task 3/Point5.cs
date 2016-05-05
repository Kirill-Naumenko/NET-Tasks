using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task_3
{
    public class  Point5
    {


        public static IEnumerable<XElement> GetAnswer(XDocument doc)
        {

            var time = from cust in doc.Descendants("customer")
                       let orders = cust.Element("orders").Elements("order").ToList()
                       where orders.Count > 0
                       let firstOrder = orders.Min(order => DateTime.Parse(order.Element("orderdate").Value))
                       select firstOrder;


            var income = from customer in doc.Root.Elements()
                      from orders in customer.Elements("orders")
                      select orders.Elements("order").Sum(sum => decimal.Parse(sum.Element("total").Value));

            
            var name = from customer in doc.Root.Elements()
                       select customer.Element("name");

            var customers = from cust in doc.Descendants("customer")
                             let orders = cust.Element("orders").Elements("order").ToList()
                             where orders.Count > 0
                             orderby orders.Min(order => DateTime.Parse(order.Element("orderdate").Value)), orders.Elements("order").Sum(sum => decimal.Parse(sum.Element("total").Value)), cust.Element("name").Value
                             select cust;
             

            //var customers =
            //    from customer in doc.Root.Elements("customer")
            //    from order in customer.Element("orders").Elements("order")
            //    orderby time, income , name descending
            //    group order.Element("orderdate").Value by customer.Element("name").Value;

            

            return customers;

        }


    }
}
