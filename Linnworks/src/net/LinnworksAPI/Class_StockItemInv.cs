using System;

namespace LinnworksAPI
{
    public class StockItemInv
    {
        public string VariationGroupName;
        public string MetaData;
        public double TaxRate;
        public Guid CategoryId;
        public Guid PackageGroupId;
        public Guid PostalServiceId;
        public double Weight;
        public double Width;
        public double Depth;
        public double Height;
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
        public double PurchasePrice;
        public double? RetailPrice;
        public string PostalServiceName;
        public string CategoryName;
        public string PackageGroupName;
        public Guid StockItemId;
    }
}