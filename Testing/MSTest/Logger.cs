using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSTest
{
    public class Logger
    {

        public void Write(string str)
        {
            string path = @"C:\Users\Kiryl_Navumenka@epam.com\WS\Testing\MSTest\Log.txt";
            
            using(StreamWriter sw = new StreamWriter(path, true))
            {
                sw.WriteLine(str);
            }
        }

    }
}
