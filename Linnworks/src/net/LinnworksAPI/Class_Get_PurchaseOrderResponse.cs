using System.Collections.Generic;

namespace LinnworksAPI
{
    public class Get_PurchaseOrderResponse
    {
        public PurchaseOrderHeader PurchaseOrderHeader;
        public List<PurchaseOrderItem> PurchaseOrderItem;
        public int NoteCount;
    }
}