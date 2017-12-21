using System;

namespace LinnworksAPI
{
    [Serializable]
    public class  OrderNote
    {
        public bool Internal;
        public string Note;
        public DateTime NoteEntryDate;
        public string NoteUserName;
        public Guid pkOrderNoteId;
    }
}