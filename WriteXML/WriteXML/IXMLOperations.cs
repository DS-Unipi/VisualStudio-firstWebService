using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WriteXML
{
    
    public class BookData
    {
        [DataMember]
        public string id { get; set; }

        [DataMember]
        public string author { get; set; }

        [DataMember]
        public string title { get; set; }

        [DataMember]
        public double price { get; set; }


    }
    
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IXMLOperations" in both code and config file together.
    [ServiceContract]
    public interface IXMLOperations
    {
        [OperationContract]
        void WriteBookToXML(BookData bookinfo);
    }
}
