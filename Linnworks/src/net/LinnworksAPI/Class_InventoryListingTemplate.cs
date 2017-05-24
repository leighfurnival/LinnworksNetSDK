using System;

namespace LinnworksAPI
{
    public class InventoryListingTemplate
    {
        public bool IsErrorMsg;
        public string Status;
        public DateTime? CreatedDate;
        public Guid InventoryItemId;
        public string Source;
        public string SubSource;
        public string CombinedSource;
    }
}