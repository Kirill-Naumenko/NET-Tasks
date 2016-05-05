using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task_3
{
    public class Point7_2
    {

        public static Dictionary<string, double> GetAnswer(XDocument doc)
        {
            var customersByCity =
                from customer in doc.Root.Elements()
                group customer.ToString().Count() by customer.Element("city").Value;


            var ordersByCity =
                (from customer in doc.Root.Elements()
                 from orders in customer.Elements("orders").Elements("order")
                 group orders.ToString().Count() by customer.Element("city").Value);


            //var intensity =
            //   from customers in doc.Element("customers")
            //   from customer in doc.Element("customers").Elements()
            //   from orders in customer.Elements("orders").Elements("order")
            //   let or = customer.Elements("orders").Elements("order").Count()
            //   let cu = doc.Element("customers").Elements().Count() where 
            //   group (double)or/cu by customer.Element("city").Value;

            var intensity = doc.Elements("customer")
               .Where(customer => customer.Element("orders").Elements("order").Any())
               .GroupBy(customer =>customer.Element("city").Value)
               .Select(list =>
               new
               {
                   name = list.Key,
                   averageOrderCount = list.Average(customer => customer.Element("orders").Elements("order").Count())
               }).ToDictionary(t=> t.name, t=> t.averageOrderCount);



            //var intensity = (from cust in customersByCity
            //                 let countCust = (Dictionary<string, int>)cust
            //                 from ord in ordersByCity
            //                 let countOrds = (Dictionary<string, int>)ord
            //                 from c in countCust
            //                 from o in countOrds
            //                 where c.Key.Equals(o.Key)
            //                 select new
            //                 {
            //                     city = c.Key,
            //                     averageIntensity = o.Value / c.Value
            //                 }).ToDictionary(t=>t.city, t=> t.averageIntensity);



            return intensity;
            
        }
    }
}
