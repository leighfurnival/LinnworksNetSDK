using System;

namespace LinnworksAPI
{
    public class OrderSummary
    {
        public Guid OrderId;
        public int NumOrderId;
        public DateTime ReceivedDate;
        public DateTime ProcessDate;
        public string Source;
        public string CustomerName;
        public int NumProducts;
        public Guid FulfillmentLocationId;
    }
}