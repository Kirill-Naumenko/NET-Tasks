using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Book
{
    [Serializable]
    public class Book
    {
        [XmlAttribute("id")]
        public string Id { get; set; }

        [XmlElement("isbn")]
        public string Isbn { get; set; }

        [XmlElement("author")]
        public string Author { get; set; }

        [XmlElement("title")]
        public string Title { get; set; }

        [XmlElement("genre")]
        public Genre Genre { get; set; }

        [XmlElement("publisher")]
        public string Publisher { get; set; }

        [XmlElement("publish_date")]
        public DateTime PublishDate { get; set; }

        public string Description { get; set; }

        public override string ToString()
        {
            return string.Format($"Id: {Id} \r\n Isbn: {Isbn} \r\n Author: {Author} \r\n Title: {Title} \r\n Genre: {Genre} \r\n Publisher: {Publisher} \r\n Publish Date: {PublishDate}" );
        }



       
    }


    public enum Genre
    {
        [XmlEnum("Computer")]
        Computer,
        [XmlEnum("Fantasy")]
        Fantasy,
        [XmlEnum("Romance")]
        Romance,
        [XmlEnum("Horror")]
        Horror,
        [XmlEnum("Science Fiction")]
        ScienceFiction
    }



    


}
