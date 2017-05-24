using System;

namespace LinnworksAPI
{
    public class AddImageToInventoryItemRequest
    {
        public string ItemNumber;
        public Guid StockItemId;
        public bool IsMain;
        public string ImageUrl;
    }
}