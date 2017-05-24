using System;
using System.Collections.Generic;

namespace LinnworksAPI
{
    public class WarehouseTransferItem
    {
        public Guid PkTransferItemId;
        public Guid FkStockItemId;
        public string SKU;
        public string Barcode;
        public string ItemTitle;
        public int RequestedQuantity;
        public int SentQuantity;
        public int? ReceivedQuantity;
        public int InFromLocationQuantity;
        public int DueFromLocationQuantity;
        public int InToLocationQuantity;
        public int ItemNoteCount;
        public string BinRackNumber;
        public Guid PkBinId;
        public List<WarehouseTransferItemNote> ItemNotes;
    }
}