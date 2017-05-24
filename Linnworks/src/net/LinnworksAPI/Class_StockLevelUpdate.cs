using System;

namespace LinnworksAPI
{
    public class StockLevelUpdate
    {
        public string SKU;
        public Guid LocationId;
        public int Level;
    }
}