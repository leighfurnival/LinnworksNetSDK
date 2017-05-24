using System;

namespace LinnworksAPI
{
    public class FulfilmentCenterImportExportSettings
    {
        public Guid fkStockLocationId;
        public int fkOrdersExportId;
        public int fkOrdersImportId;
        public int fkInventoryImportId;
        public bool OrdersExportEnabled;
        public bool OrdersImportEnabled;
        public bool InventoryImportEnabled;
    }
}