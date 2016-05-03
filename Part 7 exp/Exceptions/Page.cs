using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Exceptions.Exceptions;

namespace Exceptions
{
    class Page
    {

        public List<Button> buttons;

        

        public Page()
        {
            buttons = new List<Button>();
        }

        public void GetButtons(string path)
        {
            XDocument doc = XDocument.Load(path);
            var temp = doc.Element("elements").Element("buttons").Elements("button").ToList();




            foreach (var x in temp)
            {
                
                
                    this.buttons.Add(new Button(x.Element("name").Value));

            }
            for (int i = 0; i < this.buttons.Count; i++)
            {
                for (int j = i+1; j < this.buttons.Count-1; j++)
                {
                    if (buttons.ElementAt(i).name.Equals(buttons.ElementAt(j).name))
                    {
                        throw new NotValidData("");
                    }
                
                }
            }

            

           
           

           
        }


        public void  checkButtons(string path)
        {
            XDocument doc = XDocument.Load(path);
            var state = (from b in doc.Element("buttons").Elements("button")
                         from name in b.Elements("name")
                         from stat in b.Elements("state")
                         select new
                         {
                             name = (string)name,
                             state = (string)stat
                         }).ToDictionary(temp => temp.name.ToString(), temp => temp.state.ToString());

            for (int i = 0; i < this.buttons.Count; i++)
            {
                if (state.ContainsKey(this.buttons.ElementAt(i).name)){
                    buttons.ElementAt(i).state = state[this.buttons.ElementAt(i).name];
                }
                else
                {
                    buttons.ElementAt(i).state = "";
                }
            }


            

            

        }


        

    }
}
