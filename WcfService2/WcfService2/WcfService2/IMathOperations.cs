using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace FirstWebService
{
	[DataContract]
	public class MathsValues
	{
		[DataMember]
		public int Number1 { get; set; }
		[DataMember]
		public int Number2 { get; set; }
	}

	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IMathOperations" in both code and config file together.
	[ServiceContract]
	public interface IMathOperations
	{
		[OperationContract]
		int Addition(MathsValues obj);
		[OperationContract]
		int Subtraction(MathsValues obj);
		[OperationContract]
		int Multiplication(MathsValues obj);
		[OperationContract]
		int Division(MathsValues obj);

	}
}
