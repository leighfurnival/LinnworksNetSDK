using System;

namespace LinnworksAPI
{
    public class StockItemChangeHistory
    {
        public DateTime Date;
        public int Level;
        public double StockValue;
        public string Note;
        public int ChangeQty;
        public double ChangeValue;
        public Guid StockItemId;
    }
}