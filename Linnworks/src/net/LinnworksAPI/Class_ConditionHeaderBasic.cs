using System.Collections.Generic;

namespace LinnworksAPI
{
    public class ConditionHeaderBasic
    {
        public int pkConditionId;
        public int? fkParentConditionId;
        public int fkRuleId;
        public string ConditionName;
        public bool Enabled;
        public List<ConditionItemBasic> Conditions;
    }
}