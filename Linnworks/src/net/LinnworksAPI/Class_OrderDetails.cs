using System;
using System.Collections.Generic;

namespace LinnworksAPI
{
    public class OrderDetails
    {
        public Guid OrderId;
        public int NumOrderId;
        public bool Processed;
        public DateTime? ProcessedDateTime;
        public Guid FulfilmentLocationId;
        public OrderGeneralInfo GeneralInfo;
        public OrderShippingInfo ShippingInfo;
        public OrderCustomerInfo CustomerInfo;
        public OrderTotalsInfo TotalsInfo;
        public List<ExtendedProperty> ExtendedProperties;
        public List<string> FolderName;
        public List<OrderItem> Items;
        public List<OrderNote> Notes;
    }
}