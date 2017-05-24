using System;

namespace LinnworksAPI
{
    public class ExportRegister
    {
        public bool LastExportStatus;
        public int Id;
        public string Type;
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