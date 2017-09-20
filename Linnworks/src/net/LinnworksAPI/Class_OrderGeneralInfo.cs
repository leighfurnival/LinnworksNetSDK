using System;

namespace LinnworksAPI
{
    [Serializable]
    public class OrderGeneralInfo
    {
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
        public DateTime ReceivedDate;
        public string Source;
        public string SubSource;
        public bool HoldOrCancel;
        public DateTime DespatchByDate;
        public Guid Location;
        public int NumItems;
    }
}