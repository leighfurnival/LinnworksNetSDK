using System;
//ReSharper disable UnusedMember.Global
namespace LinnworksAPI
{
    public class BookedReturnsExchangeItem
    {
        public Guid fkOrderItemRowId;
        public string RowType;
        public string SKU;
        public string ItemTitle;
        public int ReturnQty;
        public int MaxReturnQty;
        public int? NewQty;
        public string NewSKU;
        public string NewTitle;
        public Guid? fkNewStockItemId;
        public string Category;
        public string Reason;
        public Guid fkReturnLocationId;
        public string ReturnLocation;
        public double? PendingRefundAmount;
        public bool Scrapped;
        public int? ScrapQty;
        public Guid ParentOrderItemRowId;
        public double? AdditionalCost;
        public string cCurrency;
        public int pkReturnId;
        public string ChannelReason;
        public string ChannelReasonSec;
        public DateTime ReturnDate;
    }
}