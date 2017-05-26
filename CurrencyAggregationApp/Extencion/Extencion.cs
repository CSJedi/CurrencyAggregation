
using System.Collections.Generic;
using System.Linq;
using CurrencyAggregationApp.Models;

namespace CurrencyAggregationApp.Extencion
{
	public static class Extencion
	{
		public static IEnumerable<Currency> AverageRate(this IEnumerable<Currency> list)
		{
			return from currency in list
				   group currency by currency.Code
				into currencies
				   select new Currency {
					   Code = currencies.Key, Rate = currencies.Average(row => row.Rate)};
		}

	}
}