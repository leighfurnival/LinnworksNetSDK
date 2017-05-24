namespace LinnworksAPI
{
    public class ConfigPropertySelectionList<SelectStringValueOption, Guid>
    {
        public GetSelectionList<SelectStringValueOption> OnGetSelectionList;
        public bool Loaded;
        public int pkPropertyId;
        public bool IsChanged;
        public Guid PropertyValue;
        public string PropertyType;
    }
}