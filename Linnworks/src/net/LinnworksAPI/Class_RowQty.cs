using System;

namespace LinnworksAPI
{
    public class RowQty
    {
        public Guid OrderItemRowId;
        public double Refund;
        public int Qty;
        public int? ScrapQty;
        public double AdditionalCost;
        public Guid? NewStockItemId;
        public int NewQty;
    }
}