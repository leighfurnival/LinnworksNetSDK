using System;

namespace LinnworksAPI
{
    public class AuditEntry
    {
        public int sid_history;
        public Guid fkOrderId;
        public string HistoryNote;
        public string fkOrderHistoryTypeId;
        public DateTime DateStamp;
        public string Tag;
        public string UpdatedBy;
        public string TypeDescription;
    }
}