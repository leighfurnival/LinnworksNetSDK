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
<<<<<<< HEAD
        public string ConditionDisplayName;
        public FilterLogicType FilterLogic;
        public string Value;
=======
        public String ConditionDisplayName;
        public String Value;
>>>>>>> refs/remotes/LinnSystems/master
    }
}