using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions.Exceptions
{
   public class ButtonIsDisabledException : Exception
    { 


        public string errorMessge;
    
        public ButtonIsDisabledException(string message) : base()
        {
            this.errorMessge = message;
        }

    }
}
