namespace LinnworksAPI
{
    public class RuleHeaderBasic
    {
        public int pkRuleId;
        public string RuleName;
        public bool Enabled;
        public int RunOrder;
        public RuleSetType RuleType;
        public int? pkRuleId_Draft;
        public bool Draft;
        public string RuleTypeDisplayName;
    }
}