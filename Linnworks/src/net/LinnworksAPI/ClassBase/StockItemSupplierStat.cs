using System.Text;
using System;
using System.Collections.Generic;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using System.Net.Http;
using System.Drawing;
using System.Collections.ObjectModel;
using System.Xml;
using System.ComponentModel;
using System.Reflection;

namespace LinnworksAPI
{ 
	public class StockItemSupplierStat
	{ 
		public Boolean IsDefault;
		public String Supplier;
		public Guid SupplierID;
		public String Code;
		public String SupplierBarcode;
		public Int32 LeadTime;
		public Double PurchasePrice;
		public Double MinPrice;
		public Double MaxPrice;
		public Double AveragePrice;
		public Double AverageLeadTime;
		public Int32 SupplierMinOrderQty;
		public Int32 SupplierPackSize;
		public String SupplierCurrency;
		public Guid StockItemId;
	} 
}