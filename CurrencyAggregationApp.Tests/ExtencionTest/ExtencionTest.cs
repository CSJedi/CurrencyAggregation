using System.Collections.Generic;
using System.Linq;
using CurrencyAggregationApp.Extencion;
using CurrencyAggregationApp.Models;
using NUnit.Framework;

namespace CurrencyAggregationApp.Tests.ExtencionTest
{
	[TestFixture]
	class ExtencionTest
	{
		[Test]
		public void AveragePriceTest()
		{
			var currencies = new List<Currency>
			{
				new Currency {Code = "USD", Rate = 1},
				new Currency {Code = "EUR", Rate = 2},
				new Currency {Code = "UAN", Rate = 3},
				new Currency {Code = "UAN", Rate = 3}
			};
			var result = currencies.AverageRate();

			Assert.AreEqual(3, result.Count());
			Assert.AreEqual(1, result.First(x => x.Code == "USD").Rate);
			Assert.AreEqual(2, result.First(x => x.Code == "EUR").Rate);
			Assert.AreEqual(3, result.First(x => x.Code == "UAN").Rate);
		}
	}
}
