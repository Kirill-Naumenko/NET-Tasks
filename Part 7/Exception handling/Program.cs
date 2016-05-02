using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exception_handling
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathElements = @"C:\Users\Kiryl_Navumenka@epam.com\WORKSPACE\Part 7\Exception handling\PageData.xml";
            string pathState = @"C:\Users\Kiryl_Navumenka@epam.com\WORKSPACE\Part 7\Exception handling\ButtonsState.xml";

            XDocument doc1 = XDocument.Load(pathElements);
            var names = doc1.Element("elements").Element("buttons").Elements("button").Elements("name").Select(name => name.Value);


            Console.WriteLine("Список кнопок");
            for (int i = 0; i < names.Count(); i++)
            {
                Console.WriteLine($"{i+1} {names.ElementAt(i)}");
            }

            Console.WriteLine("Производим проверку....нажмите любую клавишу");
            Console.ReadLine();



            Page page = new Page(pathElements, pathState);

            for (int i = 0; i < page.buttons.Count; i++)
            {
                Console.WriteLine($"{i+1}. {page.buttons.ElementAt(i).Name}");
            }
            Console.WriteLine("Нажмите любую клавишу, чтобы нажать на кнопки");
            Console.ReadLine();



            for (int i = 0; i < page.buttons.Count; i++)
            {
                try
                {
                    Console.WriteLine($"{i + 1}.+{page.buttons.ElementAt(i)} {page.buttons.ElementAt(i).Click()} ");
                }catch (FormatException)
                {
                    Console.WriteLine("Button disabled");
                }

            }
            

            Console.ReadKey();

        }
    }
}
