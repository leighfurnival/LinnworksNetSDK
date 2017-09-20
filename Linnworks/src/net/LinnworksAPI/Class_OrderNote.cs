using System;

namespace LinnworksAPI
{
    [Serializable]
    public class OrderNote
    {
<<<<<<< HEAD
        public bool Internal;
        public string Note;
        public DateTime NoteEntryDate;
        public string NoteUserName;
        public Guid pkOrderNoteId;
=======
        public Guid pkOrderNoteId;
        public Guid fkOrderId;
        public String Note;
        public DateTime NoteEntryDate;
        public String NoteUserName;
        public Boolean? Internal;
        public Byte? NoteTypeId;
>>>>>>> refs/remotes/LinnSystems/master
    }
}