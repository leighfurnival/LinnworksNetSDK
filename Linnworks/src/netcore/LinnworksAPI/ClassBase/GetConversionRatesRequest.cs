using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetConversionRatesRequest
	{
        /// <summary>
        /// If you want to get currencies from orders 
        /// </summary>
		public Boolean GetCurrenciesFromOrders;

        /// <summary>
        /// Currency 
        /// </summary>
		public String Currency;
	} 
}