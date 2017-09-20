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
<<<<<<< HEAD
        public bool? IsCompositeParent;
        public string ItemNumber;
        public string ItemTitle;
        public string BarcodeNumber;
        public string MetaData;
        public double PurchasePrice;
        public double? RetailPrice;
        public double TaxRate;
=======
        public Boolean? IsCompositeParent;
        public String ItemNumber;
        public String ItemTitle;
        public String BarcodeNumber;
        public String MetaData;
        public Boolean isBatchedStockType;
        public Double PurchasePrice;
        public Double? RetailPrice;
        public Double TaxRate;
>>>>>>> refs/remotes/LinnSystems/master
        public Guid PostalServiceId;
        public string PostalServiceName;
        public Guid CategoryId;
        public string CategoryName;
        public Guid PackageGroupId;
<<<<<<< HEAD
        public string PackageGroupName;
        public double Height;
        public double Width;
        public double Depth;
        public double Weight;
=======
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