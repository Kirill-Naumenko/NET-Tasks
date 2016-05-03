using Exceptions.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Button : BaseElement, IClickable
    {

        public string name;
        public string state;


        public Button(string name, string state)
        {
            this.name = name;
            this.state = state;
        }

        public Button()
        {
            this.name = null;
            this.state = null;
        }

        public Button(string name)
        {
            this.name = name;
        
        }


        public string Click()
        {
            if (this.state.Equals("enable"))
            {
                return this.name +" is enable";
            }
            if (this.state.Equals("disable"))
            {
                throw new ButtonIsDisabledException(this.name+" button is disabled");
            }
            if(this.state.Equals(""))
            {
                throw new ButtonNotExistException (this.name+" not exist");
            }

            throw new  NotValidData(this.name + " not valid data at button");

        }
    }
}
