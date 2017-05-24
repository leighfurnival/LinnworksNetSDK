using System;

namespace LinnworksAPI
{
    public class StockItemAuditTrail
    {
        public string AuditType;
        public DateTime AuditTrailDate;
        public string AuditText;
        public string UserName;
        public Guid StockItemId;
    }
}