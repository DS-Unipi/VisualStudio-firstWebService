using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BooksDataService
{

    [DataContract]
    public class BookData  {

        [DataMember]
        public string id { get; set; }

        [DataMember]
        public string author { get; set; }

        [DataMember]
        public string title { get; set; }

        [DataMember]
        public string genre { get; set; }

        [DataMember]
        public double price { get; set; }

        [DataMember]
        public string publishDate { get; set; }

        [DataMember]
        public string description { get; set; }

        public BookData(string id, string title)
        {
            this.id = id;
            this.title = title;
        }

        public BookData(string id, string author, string title, string genre, double price, string publishDate, string description)
        {
            this.id = id;
            this.author = author;
            this.title = title;
            this.genre = genre;
            this.price = price;
            this.publishDate = publishDate;
            this.description = description;
        }

    }


    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IBooksOperations" in both code and config file together.
    [ServiceContract]
    public interface IBooksOperations
    {
        [OperationContract]
        List<BookData> GetBooksTitle();

        [OperationContract]
        BookData GetBookData(string bookId);
    }
}