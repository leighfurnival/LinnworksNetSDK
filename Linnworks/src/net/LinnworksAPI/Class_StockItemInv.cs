using System;

namespace LinnworksAPI
{
    public class StockItemInv
    {
<<<<<<< HEAD
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
=======
        public String VariationGroupName;
        public Int32 Quantity;
        public Int32 InOrder;
        public Int32 Due;
        public Int32 MinimumLevel;
        public Int32 Available;
        public DateTime? CreationDate;
        public Boolean? IsCompositeParent;
        public String ItemNumber;
        public String ItemTitle;
        public String BarcodeNumber;
        public String MetaData;
        public Boolean isBatchedStockType;
        public Double PurchasePrice;
        public Double? RetailPrice;
        public Double TaxRate;
        public Guid PostalServiceId;
        public String PostalServiceName;
        public Guid CategoryId;
        public String CategoryName;
        public Guid PackageGroupId;
        public String PackageGroupName;
        public Double Height;
        public Double Width;
        public Double Depth;
        public Double Weight;
        public Int32 InventoryTrackingType;
        public Boolean BatchNumberScanRequired;
        public Boolean SerialNumberScanRequired;
>>>>>>> refs/remotes/LinnSystems/master
        public Guid StockItemId;
    }
}