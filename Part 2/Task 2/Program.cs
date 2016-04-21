using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {

            string start = "AaaA.BbbB.CccC";
            string time = DateTime.Now.ToString("hh.mm.ss.ffffff");

            string lowerCase = start.ToLower();

            string temporary = lowerCase.Replace(".", "\n");

            string temp = temporary.Replace("\n", $"\n{time}\t");
            string output = temp.Insert(0, $"{time} ");

            Console.WriteLine(start);
            Console.WriteLine(output);
            Console.ReadLine();



        }
    }
}
