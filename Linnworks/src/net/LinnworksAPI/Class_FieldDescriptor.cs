using System.Collections.Generic;

namespace LinnworksAPI
{
    public class FieldDescriptor
    {
        public string Name;
        public string FieldName;
        public string FieldGroup;
        public bool IsASet;
        public List<EvaluatorGroup> ValidEvaluatorGroups;
        public string Key;
        public string KeyDisplayName;
        public bool HasKeyOptions;
        public bool HasAttributeKey;
        public bool HasOptions;
        public DisplayType DisplayType;
        public bool ExactMatchRequired;
    }
}