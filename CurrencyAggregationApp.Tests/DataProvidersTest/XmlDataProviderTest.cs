using System;
using System.IO;
using CurrencyAggregationApp.DataProviders;
using NUnit.Framework;

namespace CurrencyAggregationApp.Tests.DataProvidersTest
{
	[TestFixture]
	class XmlDataProviderTest
	{
		[Test]
		public void DataFromXml()
		{
			var directory = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
			var path = $"{directory}/XmlTestFile.xml";

			using (var sw = File.CreateText(path))
			{
				sw.WriteLine("<rates>");
				sw.WriteLine("<currency code = \"EUR\">");
				sw.WriteLine("<rate date = \"20161201\" rate = \"30.10\"/>");
				sw.WriteLine("</currency>");
				sw.WriteLine("</rates>");
			}

			var data = new XmlDataProvider();
			var result = data.GetData(DateTime.MinValue, DateTime.MaxValue, path);
			File.Delete(path);
			Assert.AreEqual(1, result.Count);
		}
	}
}
