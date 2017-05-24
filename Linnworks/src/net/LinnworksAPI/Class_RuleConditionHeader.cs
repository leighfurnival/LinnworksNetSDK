using System.Collections.Generic;

namespace LinnworksAPI
{
    public class RuleConditionHeader
    {
        public int pkConditionId;
        public int fkRuleId;
        public int RunOrder;
        public bool Enabled;
        public string ConditionName;
        public int fkParentConditionId;
        public List<IRuleConditionItem> Conditions;
        public RuleAction Action;
        public List<RuleConditionHeader> Subrules;
    }
}