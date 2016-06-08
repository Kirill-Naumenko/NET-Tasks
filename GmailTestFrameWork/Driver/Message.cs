using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Driver
{
    public class Message
    {
        public string receiver { get; set; }
        public string subject { get; set; }
        public string text { get; set; }
        public bool attacment { get; set; }


        public Message(string receiver)
        {
            this.text = ""; 
            this.receiver = receiver;
            this.subject = "";
            attacment = false;
        }

        public Message(string receiver, string text)
        {
            this.text = text;
            this.receiver = receiver;
            this.subject = "";
            attacment = false;
        }

        public Message(string receiver, string subject, string text)
        {
            this.receiver = receiver;
            this.text = text;
            this.subject = subject;
            attacment = false;
        }

        public Message(string receiver, string subject, string text, bool attachment)
        {
            this.receiver = receiver;
            this.text = text;
            this.subject = subject;
            attacment = false;
        }

        public Message(string receiver, string text, bool attacment)
        {
            this.text = text;
            this.subject = "";
            this.receiver = receiver;
            this.attacment = true;
        }

        public Message(string receiver, bool attacment)
        {
            this.text = "";
            this.subject = "";
            this.receiver = receiver;
            this.attacment = true;
        }
    }
}
