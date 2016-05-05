using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task_3
{
   public class Point3
    {

        public static IEnumerable<XElement> GetAnswer(XDocument doc, int money)
        {

            
            var customers =
                from customer in doc.Root.Elements()
                from order in customer.Element("orders").Elements()
                where (decimal.Parse((string)order.Element("total")) > money)
                select customer;

            return customers;

        }


    }
}
