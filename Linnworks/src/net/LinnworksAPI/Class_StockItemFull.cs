using System;
using System.Collections.Generic;

namespace LinnworksAPI
{
    public class StockItemFull
    {
        public List<StockItemSupplierStat> Suppliers;
        public List<StockItemLevel> StockLevels;
        public List<StockItemDescription> ItemChannelDescriptions;
        public List<StockItemExtendedProperty> ItemExtendedProperties;
        public List<StockItemTitle> ItemChannelTitles;
        public List<StockItemPrice> ItemChannelPrices;
        public List<StockItemImage> Images;
        public string ItemNumber;
        public string ItemTitle;
        public string BarcodeNumber;
        public string MetaData;
        public double PurchasePrice;
        public double? RetailPrice;
        public double TaxRate;
        public Guid PostalServiceId;
        public string PostalServiceName;
        public Guid CategoryId;
        public string CategoryName;
        public Guid PackageGroupId;
        public string PackageGroupName;
        public double Height;
        public double Width;
        public double Depth;
        public double Weight;
        public DateTime? CreationDate;
        public Guid StockItemId;
    }
}