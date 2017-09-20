using System;
using System.Collections.Generic;

namespace LinnworksAPI
{
    //ReSharper disable UnusedMember.Global
    [Serializable]
    public class OrderItem
    {
        public Guid OrderId;
        public Guid ItemId;
        public Guid StockItemId;
        public string ItemNumber;
        public string SKU;
        public string ItemSource;
        public string Title;
        public int Quantity;
        public string CategoryName;
        public int? CompositeAvailablity;
        public Guid RowId;
        public bool StockLevelsSpecified;
        public int OnOrder;
        public int? InOrderBook;
        public int Level;
        public int? MinimumLevel;
        public int AvailableStock;
        public double PricePerUnit;
        public double UnitCost;
        public double Discount;
        public double Tax;
        public double TaxRate;
        public double Cost;
        public double CostIncTax;
        public List<OrderItem> CompositeSubItems;
        public bool IsService;
        public double SalesTax;
        public bool TaxCostInclusive;
        public bool PartShipped;
        public double Weight;
        public string BarcodeNumber;
        public int Market;
        public string ChannelSKU;
        public string ChannelTitle;
        public bool HasImage;
        public Guid? ImageId;
        public List<OrderItemOption> AdditionalInfo;
        public int StockLevelIndicator;
        public string BinRack;

        //New stuff for the new locations until we start using the new Order Input stuff.
        public int LocationID;
        public int LocationWarehouse;
    }
}