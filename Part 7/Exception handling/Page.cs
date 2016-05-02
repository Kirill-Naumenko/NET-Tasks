using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exception_handling
{
    class Page
    {

        public List<Button> buttons = new List<Button>();

        public Page(string pathElements, string pathState)
        {
            
            XDocument doc1 = XDocument.Load(pathElements);
            XDocument doc2 = XDocument.Load(pathState);
            var names = doc1.Element("elements").Element("buttons").Elements("button").Elements("name").Select(name => name.Value);

            var state = (from b in doc2.Element("buttons").Elements("button")
                         from name in b.Elements("name")
                         from st in b.Elements("state")
                         select new
                         {
                             name = (string)name,
                             state = (string)st
                         }).ToDictionary(temp => temp.name.ToString(), temp => temp.state.ToString());

            Button button = null;
            for (int i = 0; i < state.Count(); i++)

            {




                if (state.ContainsKey(names.ElementAt(i)))
                {
                    button = new Button(state.ElementAt(i).Key, state.ElementAt(i).Value);
                }
                else
                {
                    Console.WriteLine("Button " + names.ElementAt(i) + " not exist");
                    continue;
                }


                buttons.Add(button);


            }
   


            
        }

    }
}
