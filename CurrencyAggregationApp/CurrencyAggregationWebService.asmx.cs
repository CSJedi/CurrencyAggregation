using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web.Script.Services;
using CurrencyAggregationApp.DataProviders;
using CurrencyAggregationApp.Extencion;
using CurrencyAggregationApp.Models;
using System.Web.Services;

namespace CurrencyAggregationApp
{
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
	[System.ComponentModel.ToolboxItem(false)]
	// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
	// [System.Web.Script.Services.ScriptService]
	public class CurrencyAggregationWebService : System.Web.Services.WebService
	{
        [WebMethod]
		[ScriptMethod(ResponseFormat = ResponseFormat.Json)]
		public string GetCurrenciesAggregation(DateTime dateStart, DateTime dateEnd, int mode)
		{
			var currenciesResult = new List<Currency>();
			switch (mode)
			{
				case 0: currenciesResult.AddRange(GetCurrenciesFromFiles(dateStart, dateEnd).SelectMany(i => i).AverageRate()); break;
				case 1: currenciesResult.AddRange(GetCurrenciesFromFiles(dateStart, dateEnd).Select(i => i.AverageRate()).SelectMany(i => i).AverageRate()); break;
			}
            Converter converter = new Converter();
            return converter.Convert(currenciesResult);
		}

		private List<List<Currency>> GetCurrenciesFromFiles(DateTime dateStart, DateTime dateEnd)
		{
			return Directory.GetFiles(Server.MapPath("~/Files")).ToList()
				.Select(path => new FileProvider().GetDataProvider(path).GetData(dateStart, dateEnd, path).ToList()).ToList();
		}
	}
}
