using System;
using System.IO;
using CurrencyAggregationApp;
using CurrencyAggregationApp.DataProviders;
using NUnit.Framework;

namespace CurrencyAggregationApp.Tests.DataProvidersTest
{
	[TestFixture]
	class FileProviderTest
	{
		[Test]
		public void FileProviderExtencionsTest()
		{
			var fileProvider = new FileProvider();
			var fileProvider0 = fileProvider.GetDataProvider("test.csv");
			var fileProvider1 = fileProvider.GetDataProvider("test.xml");

			StringAssert.Contains("CsvDataProvider", fileProvider0.ToString());
			StringAssert.Contains("XmlDataProvider", fileProvider1.ToString());

			var exc = Assert.Throws<Exception>(
				delegate{fileProvider.GetDataProvider("test.i");});

			Assert.That(exc.Message, Is.EqualTo("File extension has not data provider"));
		}
	}
}
