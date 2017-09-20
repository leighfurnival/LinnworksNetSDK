using System;

namespace LinnworksAPI
{
    [Serializable]
    public class OrderGeneralInfo
    {
<<<<<<< HEAD
        public int Status;
        public bool LabelPrinted;
        public string LabelError;
        public bool InvoicePrinted;
        public bool PickListPrinted;
        public int Notes;
        public bool PartShipped;
        public byte? Marker;
        public string ReferenceNum;
        public string SecondaryReference;
        public string ExternalReferenceNum;
=======
        public Int32 Status;
        public Boolean LabelPrinted;
        public String LabelError;
        public Boolean InvoicePrinted;
        public Boolean PickListPrinted;
        public Boolean IsRuleRun;
        public Int32 Notes;
        public Boolean PartShipped;
        public Byte? Marker;
        public String ReferenceNum;
        public String SecondaryReference;
        public String ExternalReferenceNum;
>>>>>>> refs/remotes/LinnSystems/master
        public DateTime ReceivedDate;
        public string Source;
        public string SubSource;
        public bool HoldOrCancel;
        public DateTime DespatchByDate;
        public Guid Location;
<<<<<<< HEAD
        public int NumItems;
=======
        public Int32 NumItems;
        public IRulesEngineHelper RulesEngine;
>>>>>>> refs/remotes/LinnSystems/master
    }
}