using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drivers
{
   public class Message
    {
        public string receiver { get; set; }
        public string subject { get; set; }
        public string text { get; set; }
        public bool Attacment { get; set; }

        public Message(string receiver, string text)
        {
            this.text = text;
            this.receiver = receiver;
            this.subject = "";
            Attacment = false;
        }


        public Message(string text)
        {
            this.text = text;
            Attacment = false;
        }

        public Message(string receiver,string text, bool attacment)
        {
            this.text = text;
            this.subject = "";
            this.receiver = receiver;
            this.Attacment = true;
        }
        public Message(string receiver, bool attacment)
        {
            this.text = text;
            this.subject = "";
            this.receiver = receiver;
            this.Attacment = true;
        }




    }
}
