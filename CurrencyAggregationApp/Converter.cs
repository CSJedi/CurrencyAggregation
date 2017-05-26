using System.Collections.Generic;
using CurrencyAggregationApp.Models;
using Newtonsoft.Json;

namespace CurrencyAggregationApp
{
	public class Converter
	{
		public string Convert(List<Currency> list)
		{
			RootObject rootObject = new RootObject();
			rootObject.rates = new Rates();
			foreach (var currency in list)
			{
				switch (currency.Code)
				{
					case "USD":
						rootObject.rates.usd = new Usd();
						rootObject.rates.usd.rate = currency.Rate;
						break;
					case "EUR":
						rootObject.rates.eur = new Eur();
						rootObject.rates.eur.rate = currency.Rate;
						break;
					case "RUB":
						rootObject.rates.rur = new Rur();
						rootObject.rates.rur.rate = currency.Rate;
						break;
				}
			}
			return JsonConvert.SerializeObject(rootObject);
		}

		public class Usd
		{
			public double rate { get; set; }
		}

		public class Eur
		{
			public double rate { get; set; }
		}

		public class Rur
		{
			public double rate { get; set; }
		}

		public class Rates
		{
			public Usd usd { get; set; }
			public Eur eur { get; set; }
			public Rur rur { get; set; }
		}

		public class RootObject
		{
			public Rates rates { get; set; }
		}
	}
}