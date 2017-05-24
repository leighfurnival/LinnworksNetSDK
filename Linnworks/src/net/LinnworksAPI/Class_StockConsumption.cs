using System;

namespace LinnworksAPI
{
    public class StockConsumption
    {
        public DateTime Date;
        public int StockQuantity;
        public double StockValue;
        public int Shipped;
        public Guid StockItemId;
    }
}