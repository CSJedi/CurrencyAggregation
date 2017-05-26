using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace CurrencyAggregationApp.Models
{
	[DataContract]
	public class Currency
	{
		[DataMember]
		public string Code { get; set; }
		[DataMember]
		public double Rate { get; set; }
	}
	//[DataContract]
	//public class Currency
	//{
	//	[DataMember]
	//	public Rates rates { get; set; }
	//}

	//[DataContract]
	//public class Rates
	//{
	//	[DataMember]
	//	public Usd usd { get; set; }
	//	[DataMember]
	//	public Eur eur { get; set; }
	//	[DataMember]
	//	public Rur rur { get; set; }
	//}

	//[DataContract]
	//public class Usd
	//{
	//	[DataMember]
	//	public double rate { get; set; }
	//}

	//[DataContract]
	//public class Eur
	//{
	//	[DataMember]
	//	public double rate { get; set; }
	//}

	//[DataContract]
	//public class Rur
	//{
	//	[DataMember]
	//	public double rate { get; set; }
	//}
}
