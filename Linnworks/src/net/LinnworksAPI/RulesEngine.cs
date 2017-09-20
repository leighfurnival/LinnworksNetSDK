using Newtonsoft.Json;
using System.Collections.Generic;

namespace LinnworksAPI
{
    public static class RulesEngineMethods
    {
        private static JsonSerializerSettings serializerSettings = new JsonSerializerSettings() { DateFormatString = "yyyy-MM-ddTHH:mm:ss.ffZ" };

        public static List<EvaluatorDescriptor> GetEvaluatorTypes(string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<EvaluatorDescriptor>>(Factory.GetResponse("RulesEngine/GetEvaluatorTypes", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<FieldDescriptor> GetEvaluationFields(RuleSetType type, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<FieldDescriptor>>(Factory.GetResponse("RulesEngine/GetEvaluationFields", "type=" + JsonConvert.SerializeObject(type, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<string> GetOptions(string fieldName, RuleSetType type, string key, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<string>>(Factory.GetResponse("RulesEngine/GetOptions", "fieldName=" + fieldName + "&type=" + JsonConvert.SerializeObject(type, serializerSettings) + "&key=" + key + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<MultiOptionResponse> GetMultiOptions(RuleSetType type, List<FieldKeys> fieldKeys, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<MultiOptionResponse>>(Factory.GetResponse("RulesEngine/GetMultiOptions", "type=" + JsonConvert.SerializeObject(type, serializerSettings) + "&fieldKeys=" + JsonConvert.SerializeObject(fieldKeys, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<string> GetKeyOptions(RuleSetType type, string fieldName, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<string>>(Factory.GetResponse("RulesEngine/GetKeyOptions", "type=" + JsonConvert.SerializeObject(type, serializerSettings) + "&fieldName=" + fieldName + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<MultiKeyOptionResponse> GetMultiKeyOptions(RuleSetType type, List<string> fieldNames, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<MultiKeyOptionResponse>>(Factory.GetResponse("RulesEngine/GetMultiKeyOptions", "type=" + JsonConvert.SerializeObject(type, serializerSettings) + "&fieldNames=" + JsonConvert.SerializeObject(fieldNames, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<RuleHeaderBasic> GetRules(string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<RuleHeaderBasic>>(Factory.GetResponse("RulesEngine/GetRules", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<RuleHeaderBasic> GetRulesByType(RuleSetType type, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<RuleHeaderBasic>>(Factory.GetResponse("RulesEngine/GetRulesByType", "type=" + JsonConvert.SerializeObject(type, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<RuleConditionHeader> GetRuleConditionNodes(int pkRuleId, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<RuleConditionHeader>>(Factory.GetResponse("RulesEngine/GetRuleConditionNodes", "pkRuleId=" + pkRuleId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static ConditionHeaderBasic GetConditionWeb(int pkConditionId, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<ConditionHeaderBasic>(Factory.GetResponse("RulesEngine/GetConditionWeb", "pkConditionId=" + pkConditionId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<ActionTypeDescriptor> GetActionTypes(RuleSetType type, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<ActionTypeDescriptor>>(Factory.GetResponse("RulesEngine/GetActionTypes", "type=" + JsonConvert.SerializeObject(type, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static RuleConditionHeader CreateNewCondition(ConditionHeaderBasic header, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<RuleConditionHeader>(Factory.GetResponse("RulesEngine/CreateNewCondition", "header=" + JsonConvert.SerializeObject(header, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static void SaveConditionChanges(ConditionHeaderBasic conditionHeader, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("RulesEngine/SaveConditionChanges", "conditionHeader=" + JsonConvert.SerializeObject(conditionHeader, serializerSettings) + "", ApiToken, ApiServer);
        }

        public static bool CheckConditionNameExists(int fkRuleId, int? fkConditionId, int? excludeConditionId, string conditionName, string ApiToken, string ApiServer)
        {
<<<<<<< HEAD
            return JsonConvert.DeserializeObject<bool>(Factory.GetResponse("RulesEngine/CheckConditionNameExists", "fkRuleId=" + fkRuleId + "&fkConditionId=" + JsonConvert.SerializeObject(fkConditionId, serializerSettings) + "&excludeConditionId=" + JsonConvert.SerializeObject(excludeConditionId, serializerSettings) + "&conditionName=" + conditionName + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
=======
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Boolean>(Factory.GetResponse("RulesEngine/CheckConditionNameExists", "fkRuleId=" + fkRuleId + "&fkConditionId=" + fkConditionId + "&excludeConditionId=" + excludeConditionId + "&conditionName=" + conditionName + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
>>>>>>> refs/remotes/LinnSystems/master
        }

        public static List<string> GetActionOptions(ActionType type, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<string>>(Factory.GetResponse("RulesEngine/GetActionOptions", "type=" + JsonConvert.SerializeObject(type, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static void UpdateAction(ActionWeb action, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("RulesEngine/UpdateAction", "action=" + JsonConvert.SerializeObject(action, serializerSettings) + "", ApiToken, ApiServer);
        }

        public static ActionWeb AddAction(ActionWeb action, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<ActionWeb>(Factory.GetResponse("RulesEngine/AddAction", "action=" + JsonConvert.SerializeObject(action, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static void DeleteAction(int pkActionId, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("RulesEngine/DeleteAction", "pkActionId=" + pkActionId + "", ApiToken, ApiServer);
        }

        public static void DeleteCondition(int pkConditionId, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("RulesEngine/DeleteCondition", "pkConditionId=" + pkConditionId + "", ApiToken, ApiServer);
        }

        public static void SwapConditions(int pkConditionId1, int pkConditionId2, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("RulesEngine/SwapConditions", "pkConditionId1=" + pkConditionId1 + "&pkConditionId2=" + pkConditionId2 + "", ApiToken, ApiServer);
        }

        public static RulesFields GetRequiredFieldsByRuleId(int pkRuleId, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<RulesFields>(Factory.GetResponse("RulesEngine/GetRequiredFieldsByRuleId", "pkRuleId=" + pkRuleId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static RulesFields GetRequiredFieldsByType(RuleSetType type, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<RulesFields>(Factory.GetResponse("RulesEngine/GetRequiredFieldsByType", "type=" + JsonConvert.SerializeObject(type, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static RuleEvaluationResult TestEvaluateRule(List<TestpadValue> testValues, int pkRuleId, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<RuleEvaluationResult>(Factory.GetResponse("RulesEngine/TestEvaluateRule", "testValues=" + JsonConvert.SerializeObject(testValues, serializerSettings) + "&pkRuleId=" + pkRuleId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<TestpadValue> GetValuesFromExisting(int pkRuleId, object id, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<TestpadValue>>(Factory.GetResponse("RulesEngine/GetValuesFromExisting", "pkRuleId=" + pkRuleId + "&id=" + JsonConvert.SerializeObject(id, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static int? SetDraftLive(int pkRuleId, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<int?>(Factory.GetResponse("RulesEngine/SetDraftLive", "pkRuleId=" + pkRuleId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static int CreateDraftFromExisting(int pkRuleId, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<int>(Factory.GetResponse("RulesEngine/CreateDraftFromExisting", "pkRuleId=" + pkRuleId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static RuleHeaderBasic CreateNewDraftFromExisting(int pkRuleId, string ruleName, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<RuleHeaderBasic>(Factory.GetResponse("RulesEngine/CreateNewDraftFromExisting", "pkRuleId=" + pkRuleId + "&ruleName=" + ruleName + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static RuleHeaderBasic CreateNewDraft(string ruleName, RuleSetType type, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<RuleHeaderBasic>(Factory.GetResponse("RulesEngine/CreateNewDraft", "ruleName=" + ruleName + "&type=" + JsonConvert.SerializeObject(type, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static void SetRuleEnabled(int pkRuleId, bool enabled, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("RulesEngine/SetRuleEnabled", "pkRuleId=" + pkRuleId + "&enabled=" + enabled + "", ApiToken, ApiServer);
        }

        public static void SetRuleName(int pkRuleId, string ruleName, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("RulesEngine/SetRuleName", "pkRuleId=" + pkRuleId + "&ruleName=" + ruleName + "", ApiToken, ApiServer);
        }

        public static void DeleteRuleById(int pkRuleId, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("RulesEngine/DeleteRuleById", "pkRuleId=" + pkRuleId + "", ApiToken, ApiServer);
        }

        public static void SwapRules(int pkRuleId1, int pkRuleId2, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("RulesEngine/SwapRules", "pkRuleId1=" + pkRuleId1 + "&pkRuleId2=" + pkRuleId2 + "", ApiToken, ApiServer);
        }

        public static void SetConditionEnabled(int pkConditionId, bool enabled, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("RulesEngine/SetConditionEnabled", "pkConditionId=" + pkConditionId + "&enabled=" + enabled + "", ApiToken, ApiServer);
        }

        public static RuleConditionHeader CopyCondition(int pkRuleId, int? targetParentConditionId, int pkConditionId, bool includeChildren, bool includeActions, string ApiToken, string ApiServer)
        {
<<<<<<< HEAD
            return JsonConvert.DeserializeObject<RuleConditionHeader>(Factory.GetResponse("RulesEngine/CopyCondition", "pkRuleId=" + pkRuleId + "&targetParentConditionId=" + JsonConvert.SerializeObject(targetParentConditionId, serializerSettings) + "&pkConditionId=" + pkConditionId + "&includeChildren=" + includeChildren + "&includeActions=" + includeActions + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
=======
            return Newtonsoft.Json.JsonConvert.DeserializeObject<RuleConditionHeader>(Factory.GetResponse("RulesEngine/CopyCondition", "pkRuleId=" + pkRuleId + "&targetParentConditionId=" + targetParentConditionId + "&pkConditionId=" + pkConditionId + "&includeChildren=" + includeChildren + "&includeActions=" + includeActions + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
>>>>>>> refs/remotes/LinnSystems/master
        }

        public static RuleAction CopyAction(int pkRuleId, int targetParentConditionId, int pkActionId, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<RuleAction>(Factory.GetResponse("RulesEngine/CopyAction", "pkRuleId=" + pkRuleId + "&targetParentConditionId=" + targetParentConditionId + "&pkActionId=" + pkActionId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }
    }
}