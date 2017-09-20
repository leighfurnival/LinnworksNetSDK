using System;
using System.Collections.Generic;

namespace LinnworksAPI
{
    public class Deliver_PurchaseOrderItemAllNoBatchResponse
    {
        public Deliver_PurchaseOrderItemAllResponse poHeaderAndItems;
        public Boolean allItemsDelivered;
        public String message;
    }
    public class Deliver_PurchaseOrderItemAllResponse
    {
        public List<PurchaseOrderItem> PurchaseOrderItems;
        public PurchaseOrderHeader PurchaseOrderHeader;
    }
}