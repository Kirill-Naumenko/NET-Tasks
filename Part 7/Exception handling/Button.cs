using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_handling
{
    class Button : BaseElement, IClickable
    {

        public string Name { get; set; }

        public string Enabled { get; set; }


        public Button(string name , string state)
        {

            this.Name = name;
            this.Enabled = state;

            if (state.Equals("enable"))
            {
                this.Enabled = "enable";
            }if(state.Equals("disable"))
                    
            {
                this.Enabled = "disable";
            }

            this.Enabled = "Not valid data";

        }

        


        public string Click()
        {
            if (this.Enabled.Equals("enable"))
            {
                return (this.Name + "работает");
            }
            if (this.Enabled.Equals("disable"))
            {
                return "Button disabled";
            }


            return "Invalid data";
        }
    }
}
