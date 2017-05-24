using System;

namespace LinnworksAPI
{
    public class WarehouseTransferAudit
    {
        public Guid PkTransferAuditId;
        public AuditType AuditType;
        public int nAuditType;
        public DateTime AuditDate;
        public string AuditNote;
    }
}