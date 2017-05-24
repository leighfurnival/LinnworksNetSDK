using System;

namespace LinnworksAPI
{
    public class PurchaseOrderAudit
    {
        public Guid pkPurchaseAuditTrailId;
        public DateTime AuditTrailDateTimeStamp;
        public Guid fkPurchaseId;
        public string AuditTrailType;
        public string AuditTrailTag;
        public string AuditTrailNote;
        public string UserName;
        public string AuditTrailDate;
        public string AuditTrailTime;
    }
}