using System;

namespace LinnworksAPI
{
    public class OrderAuditTrail
    {
        public DateTime Date;
        public string Type;
        public string Note;
        public string User;
        public string fkOrderHistoryTypeId;
        public string Tag;
    }
}