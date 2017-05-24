using System;

namespace LinnworksAPI
{
    public class ReturnInfo
    {
        public int pkReturnId;
        public ReturnType RowType;
        public string ReturnReference;
        public Guid fkOrderId;
        public Guid fkOrderItemRowId;
        public int nOrderId;
        public string SKU;
        public string ItemTitle;
        public string Reason;
        public string ChannelReason;
        public string ChannelReasonSec;
        public string Category;
        public int ReturnQty;
        public Guid? fkReturnLocationId;
        public bool Scrapped;
        public int? ScrapQty;
        public string LastState;
        public DateTime LastDate;
        public bool Completed;
        public Guid? fkNewOrderId;
        public Guid? fkNewOrderItemRowId;
        public Guid? fkNewStockItemId;
        public int? NewQty;
        public int? NewOrderId;
        public bool NewOrderCancelled;
        public string NewSKU;
        public string NewItemTitle;
        public DateTime? NewOrderProcessedOn;
        public double? AdditionalCost;
        public Guid? fkRefundRowId;
        public double? RefundedAmount;
        public double? PendingRefund;
        public DateTime ReturnDate;
    }
}