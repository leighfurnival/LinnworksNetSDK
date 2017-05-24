using System;

namespace LinnworksAPI
{
    public class AddImageToInventoryItemResponse
    {
        public Guid StockItemId;
        public Guid ImageId;
        public string ImageUrl;
        public string ImageThumbnailUrl;
    }
}