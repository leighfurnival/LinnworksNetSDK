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
{ [JsonConverter(typeof(StringEnumConverter))]
public enum ColumnNameType
{ SKU,
Title,
VariationGroupName,
RetailPrice,
PurchasePrice,
Tracked,
Barcode,
Available,
MinimumLevel,
InOrder,
StockLevel,
StockValue,
Due,
BinRack,
Category,
Image,
Weight,
DimHeight,
DimWidth,
DimDepth,
CreatedDate,
ModifiedDate,
SerialNumberScanRequired,
BatchNumberScanRequired,
BatchType,
 
} 
}