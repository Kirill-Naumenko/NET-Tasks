using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exceptions.Exceptions;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            int choose;
            Page page = new Page();
            

            try
            {
                page.GetButtons(@"C:\Users\Kiryl_Navumenka@epam.com\WORKSPACE\Part 7\Exceptions\PageData.xml");
            }catch (NotValidData e)
            {
                Console.WriteLine(" Error, some button have more than 1 instance");
                Console.ReadKey();
                Environment.Exit(0);
            }
           

            while (true)
            {
                Console.WriteLine("Choose you action");
                Console.WriteLine("\r\n");
                Console.WriteLine("0. Show all buttons");
                Console.WriteLine("1. Click all buttons");
                Console.WriteLine("2. Exit");

                while (true)
                {


                   
                    if (Int32.TryParse(Console.ReadLine(), out choose))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Input correct point pls");
                    }

                }


                switch (choose)
                {
                    case 0:
                        Console.WriteLine("Buttons :");
                        for (int i = 0; i < page.buttons.Count; i++)
                        {
                            Console.WriteLine(page.buttons.ElementAt(i).name);
                        }
  
                        break;

                    case 1:

                        try
                        {
                            page.checkButtons(@"C:\Users\Kiryl_Navumenka@epam.com\WORKSPACE\Part 7\Exceptions\ButtonState.xml");
                        }
                        catch (ArgumentException e)
                        {
                            Console.WriteLine(" Error, on of the button have more than 1 instance");
                            break;
                        }


                        for (int i = 0; i < page.buttons.Count; i++)
                        {

                            try
                            {
                                
                                Console.WriteLine(page.buttons.ElementAt(i).name + " " + page.buttons.ElementAt(i).Click());
                            }
                            catch (ButtonNotExistException e)
                            {
                                Console.WriteLine(page.buttons.ElementAt(i).name + " is not exist");
                            }
                            catch (ButtonIsDisabledException e)
                            {
                                Console.WriteLine(page.buttons.ElementAt(i).name + " is disabled");
                            }
                            catch (NotValidData e)
                            {
                                Console.WriteLine(page.buttons.ElementAt(i).name + " have not valid data");
                            }
                            
                        }
                        Console.WriteLine("\r\n");
                        break;

                    case 2:
                        Environment.Exit(0);
                        break;

                }
                    
            }
            
           




           


        }


    }
}
