using System;

namespace LinnworksAPI
{
    public class WarehouseTransferBinNote
    {
        public Guid PkTransferBinNoteId;
        public string NoteUser;
        public string Note;
        public DateTime NoteDateTime;
        public bool NoteRead;
        public Guid PkBinId;
    }
}