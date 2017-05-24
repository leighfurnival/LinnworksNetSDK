using System;

namespace LinnworksAPI
{
    public class ImportRegister
    {
        public string LastFileChecksum;
        public string ImportStatus;
        public bool ImportSkipped;
        public int Id;
        public ImportType Type;
        public string FriendlyName;
        public bool Executing;
        public bool justOnce;
        public DateTime? Started;
        public DateTime? Completed;
        public bool IsQueued;
        public bool Enabled;
        public bool IsNew;
        public bool AllSchedulesDisabled;
        public DateTime? NextSchedule;
    }
}