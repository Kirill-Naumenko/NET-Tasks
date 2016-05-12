using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Book
{
    [Serializable]
    [XmlRoot("catalog", Namespace = "http://library.by/catalog")]
    public class Catalog
    {

        [XmlAttribute("data", DataType ="date")]
        public DateTime Date { get; set; }

        [XmlElement("book", Type = typeof(Book))]
        public List<Book> Books{ get; set; }

        public Catalog()
        {
            Books = new List<Book>();
        }

        public Catalog(List<Book> books)
        {
            Books = books;
        }

        //public Catalog(string path)
        //{
        //    catalog = new List<Book>();
        //    XDocument doc = XDocument.Load(path);
        //    var temp = doc.Root.Elements().ToList();

        //    foreach (var x in temp)
        //    {

        //        this.catalog.Add(new Book()
        //        {
        //            Id = x.Attribute("id").Value,
        //            Isbn = x.Element("isbn").Value,
        //            Author = x.Element("author").Value,
        //            Title = x.Element("title").Value,
        //            //Genre = (Genre)Enum.Parse(typeof(Genre),x.Element("genre").Value),
        //            Publisher = x.Element("publisher").Value,
        //            PublishDate = DateTime.Parse(x.Element("publish_date").Value),
        //        }
        //            );

        //    }

        //}
    }
}
