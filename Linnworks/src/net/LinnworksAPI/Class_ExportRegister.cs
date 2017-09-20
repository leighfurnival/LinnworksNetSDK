using System;

namespace LinnworksAPI
{
    public class ExportRegister
    {
<<<<<<< HEAD
        public bool LastExportStatus;
        public int Id;
        public string Type;
        public string FriendlyName;
        public bool Executing;
        public bool justOnce;
=======
        public DateTime? LastQueryExecuted;
        public Boolean LastExportStatus;
        public Int32 Id;
        public String Type;
        public String FriendlyName;
        public Boolean Executing;
        public Boolean justOnce;
>>>>>>> refs/remotes/LinnSystems/master
        public DateTime? Started;
        public DateTime? Completed;
        public bool IsQueued;
        public bool Enabled;
        public bool IsNew;
        public bool AllSchedulesDisabled;
        public DateTime? NextSchedule;
    }
}