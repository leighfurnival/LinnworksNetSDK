using System;

namespace LinnworksAPI
{
    public class StockItemExtendedProperty
    {
        public Guid pkRowId;
        public Guid fkStockItemId;
        public string ProperyName;
        public string PropertyValue;
        public string PropertyType;
    }
}