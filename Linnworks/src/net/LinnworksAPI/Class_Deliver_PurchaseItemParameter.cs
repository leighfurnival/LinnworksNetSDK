using System;

namespace LinnworksAPI
{
    public class Deliver_PurchaseItemParameter
    {
        public String BatchNumber;
        public String BinRack;
        public Int32 PrioritySequence;
        public String BatchStatus;
        public Guid pkPurchaseId;
        public Guid pkPurchaseItemId;
        public int? Delivered;
        public int? AddToDelivered;
    }
}