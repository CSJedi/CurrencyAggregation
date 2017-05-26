using System;
using System.IO;
using CurrencyAggregationApp;
using CurrencyAggregationApp.DataProviders;
using NUnit.Framework;

namespace CurrencyAggregationApp.Tests.DataProvidersTest
{
	[TestFixture]
	class CsvDataProviderTest
	{
		[Test]
		public void DataFromCsv()
		{
			var directory = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
			var path = $"{directory}\\CsvTestFile.csv";

			using (var sw = File.CreateText(path))
			{
				sw.WriteLine("USD, 20170102, 27.10");
				sw.WriteLine("USD, 20170103, 27.15");
				sw.WriteLine("EUR, 20170103, 30.15");
				sw.WriteLine("EUR, 20170103, 30.31");
			}

			var data = new CsvDataProvider();
			var result = data.GetData(DateTime.MinValue, DateTime.MaxValue, path);
			File.Delete(path);
			Assert.AreEqual(4, result.Count);
		}
	}
}
