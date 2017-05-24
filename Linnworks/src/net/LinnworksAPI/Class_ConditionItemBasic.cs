using System.Collections.Generic;

namespace LinnworksAPI
{
    public class ConditionItemBasic
    {
        public int pkConditionItemId;
        public int fkConditionId;
        public string FieldName;
        public EvaluatorType Evaluation;
        public List<string> Values;
        public string KeyValue;
    }
}