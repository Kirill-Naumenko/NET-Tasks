using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int money = 100000;

            XDocument doc = XDocument.Load(@"C:\Users\Kiryl_Navumenka@epam.com\WORKSPACE\Part 5\Task 3\Customers.xml");



            ////Point 1 Done!
            //var customers =
            //     from customer in doc.Root.Elements()
            //     from orders in customer.Elements("orders")
            //     where orders.Elements("order").Sum(sum => decimal.Parse(sum.Element("total").Value)) > money
            //     select customer;

            //foreach (var y in customers)
            //{
            //    Console.WriteLine($"Customer: {(string)y.Element("name")}");
            //}
            //Console.ReadKey();



            ////Point 2 DONE!
            //var customers =
            //    from customer in doc.Root.Elements()
            //    group customer by (string)customer.Element("country");

            //foreach ( var x in p2)
            //{
            //    Console.WriteLine(x.Key);
            //    foreach(var t in x)
            //    {
            //        Console.WriteLine("\t\t"+(string)t.Element("name"));
            //    }
            //}



            //Point 3 Done!
            //var customers = 
            //    from customer in doc.Root.Elements()
            //    from order in customer.Element("orders").Elements()
            //    where (decimal.Parse((string)order.Element("total")) > money)
            //    select customer;

            //foreach (var y in customers)
            //{
            //    Console.WriteLine($"Customer: {(string)y.Element("id")}");
            //}
            //Console.ReadKey();



            ////Point 4 Done!

            //var cust =
            //    from customer in doc.Root.Elements("customer")
            //    from order in customer.Element("orders").Elements("order")
            //    orderby DateTime.Parse(order.Element("orderdate").Value)
            //    group order.Element("orderdate").Value by customer.Element("name").Value;

            //foreach ( var t in cust)
            //{
            //    Console.WriteLine("name " + t.Key);
            //    foreach (var r in t)
            //    {
            //        Console.WriteLine("\t\t date "+r);
            //    }

            //}






            ////Point 5 Done!
            //var inc = from customer in doc.Root.Elements()
            //          from orders in customer.Elements("orders")
            //          select orders.Elements("order").Sum(sum => decimal.Parse(sum.Element("total").Value));

            //var time = from customer in doc.Root.Elements("customer")
            //           from order in customer.Element("orders").Elements("order")
            //           select DateTime.Parse(order.Element("orderdate").Value);
            //var name = from customer in doc.Root.Elements()
            //           select customer.Element("name");


            //var cust =
            //    from customer in doc.Root.Elements("customer")
            //    from order in customer.Element("orders").Elements("order")
            //    orderby time, inc , name descending
            //    group order.Element("orderdate").Value by customer.Element("name").Value;

            //foreach (var t in cust)
            //{
            //    Console.WriteLine("name " + t.Key);
            //    foreach (var r in t)
            //    {
            //        Console.WriteLine("\t\t date " + r);
            //    }

            //}








            

            



            //Point 6 Done!
            //int temp = 0;
            //var customers =
            //    from customer in doc.Root.Elements()
            //    where
            //    !customer.Element("phone").ToString().Contains("(")
            //    || Int32.TryParse((string)customer.Element("postalcode"), out temp)
            //    || String.IsNullOrEmpty((string)customer.Element("region"))

            //    select customer;

            //foreach (var t in customers)
            //{
            //    Console.WriteLine((string)t.Element("name")+ " PHONE "+(string)t.Element("phone"));
            //    Console.WriteLine((string)t.Element("name") + " CODE " +(string)t.Element("postalcode"));
            //    Console.WriteLine((string)t.Element("name") + " REGION " +(string)t.Element("region"));
            //}





            Console.ReadKey();



        }
    }
}
