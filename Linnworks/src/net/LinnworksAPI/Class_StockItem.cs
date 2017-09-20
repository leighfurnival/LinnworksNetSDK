using System;

namespace LinnworksAPI
{
    public class StockItem
    {
        public int Quantity;
        public int InOrder;
        public int Due;
        public int MinimumLevel;
        public int Available;
        public DateTime? CreationDate;
        public bool? IsCompositeParent;
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
        public Guid StockItemId;
    }
}