namespace LinnworksAPI
{
    public class RuleAction
    {
        public int pkActionId;
        public string ActionName;
        public ActionType ActionType;
        public string ActionValue;
        public int fkConditionId;
        public int RuleVersion;
        public int fkRuleId;
    }
}