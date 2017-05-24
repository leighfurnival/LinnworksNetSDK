using System.Collections.Generic;

namespace LinnworksAPI
{
    public class FieldVisibility
    {
        public string Name;
        public bool Visible;
        public bool CanFilter;
        public bool CanSort;
        public FieldTypes FieldType;
        public FieldCode Code;
        public List<FieldVisibility> SubFields;
        public string HotButtonIcon;
        public string HotButtonKey;
    }
}