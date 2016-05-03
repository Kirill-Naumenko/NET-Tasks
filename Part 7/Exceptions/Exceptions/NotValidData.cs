using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions.Exceptions
{
    class NotValidData: Exception
    {
        public string errorMessge;

        public NotValidData(string message) : base()
        {
            this.errorMessge = message;
        }

    }
}
