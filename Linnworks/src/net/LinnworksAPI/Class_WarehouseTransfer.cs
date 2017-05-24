using System;
using System.Collections.Generic;

namespace LinnworksAPI
{
    public class WarehouseTransfer
    {
        public Guid PkTransferId;
        public Guid FromLocationId;
        public Guid ToLocationId;
        public string FromLocation;
        public string ToLocation;
        public TransferStatus Status;
        public int nStatus;
        public string ReferenceNumber;
        public DateTime OrderDate;
        public int NumberOfItems;
        public int NumberOfNotes;
        public Guid fkOriginalTransferId;
        public string OriginalTransferReference;
        public bool IsDiscrepancyTransfer;
        public bool BLogicalDelete;
        public List<WarehouseTransferBin> Bins;
        public List<WarehouseTransferNote> Notes;
        public List<WarehouseTransferAudit> AuditTrail;
        public List<WarehouseTransferProperty> TransferProperties;
        public UpdateStatus UpdateStatus;
    }
}