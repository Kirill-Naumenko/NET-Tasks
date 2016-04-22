using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectoryMaker
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите имя папки");
            string folderName = Console.ReadLine();

         
            string pathFolder = @"C:\Users\Kiryl_Navumenka@epam.com\Desktop\" + folderName;

            try
            {
               
                if (Directory.Exists(pathFolder))
                {
                    Console.WriteLine("Папка уже существует");
                    
                    return;
                }

               
                Directory.CreateDirectory(pathFolder);
                Console.WriteLine("Папка успешно создана");
                

            }
            catch (Exception e)
            {
                Console.WriteLine("Что-то пошло не так :(");
            }

            //string pathFile = $@"C:\Users\Kiryl_Navumenka@epam.com\Desktop\{folderName}\text.txt";
            //string[] lines = { "1", "2", "3" , "4", "5","6"};
            //File.WriteAllLines(pathFile, lines);

            //StreamReader reader = new StreamReader(pathFile);

            //string s = String.Empty;
            //string main = String.Empty;
            //for (int i = 0; i < 4; i++)
            //{
            //    s = reader.ReadLine();
            //    main = main + s + "\r\n";
            //}



            //string secondPathFile = $@"C:\Users\Kiryl_Navumenka@epam.com\Desktop\{folderName}\text2.txt";
            //File.WriteAllText(secondPathFile, main);
            //Console.ReadLine();



            string pathFile = $@"C:\Users\Kiryl_Navumenka@epam.com\Desktop\{folderName}\text.txt";
            string secondPathFile = $@"C:\Users\Kiryl_Navumenka@epam.com\Desktop\{folderName}\text2.txt";

            string[] lines = { "1", "2", "3", "4", "5", "6" };
            File.WriteAllLines(pathFile, lines);
            

            StreamReader reader = new StreamReader(pathFile);
            StringWriter writer = new StringWriter();

            string s = String.Empty;
            for (int i = 0; i < 4; i++)
            {
                s = reader.ReadLine();
                writer.WriteLine(s);
            }

            File.WriteAllText(secondPathFile, writer.ToString());

            Console.ReadLine();



        }
    }
}
