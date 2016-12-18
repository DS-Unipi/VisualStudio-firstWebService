using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Web.Hosting;
using System.Xml;
using System.IO;

namespace WriteXML
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "XMLOperations" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select XMLOperations.svc or XMLOperations.svc.cs at the Solution Explorer and start debugging.
    public class XMLOperations : IXMLOperations
    {
        public void DoWork()
        {
        }

        public void WriteBookToXML(BookData bookinfo)
        {
            XmlDocument doc = new XmlDocument();

            XmlElement bookElem = doc.CreateElement("book");
            bookElem.SetAttribute("id", bookinfo.id);

            XmlElement authorElem = doc.CreateElement("author");
            authorElem.InnerText = bookinfo.author;

            XmlElement titleElem = doc.CreateElement("title");
            titleElem.InnerText = bookinfo.title;

            XmlElement priceElem = doc.CreateElement("price");
            priceElem.InnerText = bookinfo.price.ToString();

            bookElem.AppendChild(authorElem);
            bookElem.AppendChild(titleElem);
            bookElem.AppendChild(priceElem);

            string fileName = HostingEnvironment.MapPath(@"~/App_data/books.xml");
            if (File.Exists(fileName))
            {
                doc.Load(fileName);
                XmlElement root = doc.DocumentElement;
                root.AppendChild(bookElem);
            } else
            {
                XmlElement root = doc.CreateElement("catalog");
                root.AppendChild(bookElem);
                doc.AppendChild(root);
            }
            doc.Save(fileName);
        }
    }
}
