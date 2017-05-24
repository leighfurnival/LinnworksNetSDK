using System.Collections.Generic;

namespace LinnworksAPI
{
    public class Filter
    {
        public FilterNameType FilterName;
        public string DisplayName;
        public List<string> FilterNameExact;
        public FieldType Field;
        public ConditionType Condition;
        public string ConditionDisplayName;
        public FilterLogicType FilterLogic;
        public string Value;
    }
}