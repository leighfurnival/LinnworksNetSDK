using System;

namespace LinnworksAPI
{
    public class ServiceItem
    {
        public Guid pkOrderItemRowId;
        public string ServiceName;
        public double ServiceCost;
        public ChannelRefundReason DefaultChannelReason;
        public ChannelRefundSubReason DefaultChannelSubReason;
        public string ItemNumber;
        public bool AllowsAutomatedRefund;
    }
}