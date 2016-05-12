using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Xml.Serialization;
using System.IO;
using System.Xml;

namespace Book
{
    class Program
    {
        static void Main(string[] args)
        {
            string BookSerialize = "BookSerialize.xml";
            string BooksDeserialize = "BookDeserialize.xml";
            string CatalogSerialize = "CatalogSerialize.xml";
            string CatalogDeserialize = @"C:\Users\Kiryl_Navumenka@epam.com\WS\SerializationXML\Book\books.xml";

            Book Book = new Book()
            {
                Id = "bk101",
                Isbn = "0-596-00103-7",
                Author = "Löwy, Juval",
                Title = "COM and .NET Component Services",
                Genre = Genre.Computer,
                Publisher = "O'Reilly",
                PublishDate = DateTime.Parse("2001-09-01"),

            };

            Catalog catlg;


            var BookSerializer = new XmlSerializer(typeof(Book));




            //using (Stream stream = new FileStream(BookSerialize, FileMode.Create))
            //{
            //    BookSerializer.Serialize(stream, Book);
            //}

            //using (Stream stream = new FileStream(BookSerialize, FileMode.Open))
            //{
            //    Book book = BookSerializer.Deserialize(new FileStream(BooksDeserialize, FileMode.Open)) as Book;
            //    Console.WriteLine(book.ToString());
            //}




            var CatalogSerializer = new XmlSerializer(typeof(Catalog));

            using (Stream stream = new FileStream(CatalogDeserialize, FileMode.Open))
            {
                catlg = CatalogSerializer.Deserialize(stream) as Catalog;
                for (int i = 0; i < catlg.Books.Count; i++)
                {
                    
                    Console.WriteLine(catlg.Books[i].ToString());
                    
                }

            }

            using (StreamWriter stream = new StreamWriter(new FileStream(CatalogSerialize, FileMode.Create), Encoding.UTF8))
            {
                XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
                ns.Add("", "http://library.by/catalog");
                CatalogSerializer.Serialize(stream, catlg , ns);
            }




            Console.ReadKey();

        }
        
    }
}
