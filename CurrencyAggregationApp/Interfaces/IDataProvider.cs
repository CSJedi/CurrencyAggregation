using System;
using System.Collections.Generic;
using CurrencyAggregationApp.Models;

namespace CurrencyAggregationApp.Interfaces
{
	public interface IDataProvider
	{
		List<Currency> GetData(DateTime dateStart, DateTime dateEnd, string filePath);

	}
}