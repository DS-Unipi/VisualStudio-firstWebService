using BooksDataService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Web.Hosting;
using System.Xml;

namespace ReadXML
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "BooksOperations" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select BooksOperations.svc or BooksOperations.svc.cs at the Solution Explorer and start debugging.
    public class BooksOperations : IBooksOperations
    {
        public BookData GetBookData(string bookId)
        {
            XmlDocument doc = new XmlDocument();

            doc.Load(HostingEnvironment.MapPath(@"~/App_Data/books.xml"));
            foreach (XmlNode node in doc.SelectNodes("catalog/book[@id='" + bookId + "']"))
            {
                if (node.HasChildNodes)
                {
                    string author = node.SelectSingleNode("author").InnerText;
                    string title = node.SelectSingleNode("title").InnerText;
                    string genre = node.SelectSingleNode("genre").InnerText;
                    double price = Double.Parse(node.SelectSingleNode("price").InnerText);
                    string publish_date = node.SelectSingleNode("publish_date").InnerText;
                    string description = node.SelectSingleNode("description").InnerText;

                    return new BookData(bookId, author, title, genre, price, publish_date, description);
                }
            }

            return null;
        }

        public List<BookData> GetBooksTitle()
        {
            List<BookData> books = new List<BookData>();
            string title = "";
            XmlDocument doc = new XmlDocument();

            doc.Load(HostingEnvironment.MapPath(@"~/App_Data/books.xml"));
            foreach (XmlNode node in doc.SelectNodes("catalog/book"))
            {
                title = node.SelectSingleNode("title").InnerText;
                books.Add(new BookData(node.Attributes["id"].InnerText, title));
            }
            return books;
        }
    }
        
}
