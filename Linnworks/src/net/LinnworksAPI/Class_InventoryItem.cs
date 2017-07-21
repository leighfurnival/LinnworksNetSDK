using System;
using System.Collections.Generic;

namespace LinnworksAPI
{
    //ReSharper disable UnusedMember.Global
    public class InventoryItem
    {
        public Guid Id;
        public string SKU;
        public string Title;
        public double? RetailPrice;
        public double? PurchasePrice;
        public string Barcode;
        public int Available;
        public int MinimumLevel;
        public int InOrder;
        public int StockLevel;
        public double StockValue;
        public int Due;
        public bool Tracked;
        public string BinRack;
        public Guid Category;
        public bool IsComposite;
        public bool IsArchived;
        public string Image;
        public DateTime? CreatedDate;
        public DateTime? ModifiedDate;
        public string VariationGroupName;
        public List<InventoryItem> Products;
        public Dictionary<string, ChannelDetails> Channels;
        public int TotalChangedProducts;
        public bool ContainsChanges;
    }
}