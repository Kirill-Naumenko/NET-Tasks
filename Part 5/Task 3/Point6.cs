using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task_3
{
    class Point6
    {
        public static IEnumerable<XElement> GetAnswer(XDocument doc)
        {

            int temp = 0;
            var customers =
                from customer in doc.Root.Elements()
                where
                !customer.Element("phone").ToString().Contains("(")
                || Int32.TryParse((string)customer.Element("postalcode"), out temp)
                || String.IsNullOrEmpty((string)customer.Element("region"))

                select customer;



            return customers;

        }

    }
}
