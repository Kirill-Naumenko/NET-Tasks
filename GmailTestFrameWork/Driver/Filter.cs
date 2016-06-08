using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Driver
{
    public class Filter
    {
        public string from { get; set; }
        public bool attachment { get; set; }
        public bool deleteIt { get; set; }
        public bool markAsImportant { get; set; }

        public Filter(string login)
        {
            from = login;
            attachment = false;
            deleteIt = false;
            markAsImportant = false;
        }
    }
}
