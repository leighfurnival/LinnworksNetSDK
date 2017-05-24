using System;

namespace LinnworksAPI
{
    public class WarehouseTransferNote
    {
        public Guid PkTransferNoteId;
        public string NoteUser;
        public string Note;
        public DateTime NoteDateTime;
        public bool NoteRead;
    }
}