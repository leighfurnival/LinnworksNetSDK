using System;

namespace LinnworksAPI
{
    public class Deliver_PurchaseItemParameter
    {
        public Guid pkPurchaseId;
        public Guid pkPurchaseItemId;
        public int? Delivered;
        public int? AddToDelivered;
    }
}