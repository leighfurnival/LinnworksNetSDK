using System;

namespace LinnworksAPI
{
    public class WarehouseTransferItemNote
    {
        public Guid PkTransferItemNoteId;
        public string NoteUser;
        public string Note;
        public DateTime NoteDateTime;
        public bool NoteRead;
        public Guid FkBinId;
        public Guid PkTransferItemId;
    }
}