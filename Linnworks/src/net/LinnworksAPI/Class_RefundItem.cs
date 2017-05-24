using System;

namespace LinnworksAPI
{
    public class RefundItem
    {
        public Guid? pkRefundRowId;
        public bool IsManualRefund;
        public RefundItemType Type;
        public Guid? fkOrderItemId;
        public int RefundQty;
        public double RefundAmount;
        public string Reason;
        public string ChannelReason;
        public string ChannelReasonSec;
    }
}