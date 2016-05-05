using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task_3
{
    public class Point2
    {


        public static IEnumerable<IGrouping<string, string>> GetAnswer(XDocument doc)
        {
            var customers =
                from customer in doc.Root.Elements()
                group customer.Element("name").Value by (string)customer.Element("country");

            return customers;

        }

    }
}
