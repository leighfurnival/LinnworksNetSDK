using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace LinnworksAPI
{
    public static class PurchaseOrderMethods
    {
        private static JsonSerializerSettings serializerSettings = new JsonSerializerSettings() { DateFormatString = "yyyy-MM-ddTHH:mm:ss.ffZ" };

        public static Search_PurchaseOrdersResult Search_PurchaseOrders(Search_PurchaseOrderParameter searchParameter, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<Search_PurchaseOrdersResult>(Factory.GetResponse("PurchaseOrder/Search_PurchaseOrders", "searchParameter=" + JsonConvert.SerializeObject(searchParameter, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static Guid Create_PurchaseOrder_Initial(Create_PurchaseOrder_InitialParameter createParameters, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<Guid>(Factory.GetResponse("PurchaseOrder/Create_PurchaseOrder_Initial", "createParameters=" + JsonConvert.SerializeObject(createParameters, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static PurchaseOrderHeader Update_PurchaseOrderHeader(Update_PurchaseOrderHeaderParameter updateParameter, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<PurchaseOrderHeader>(Factory.GetResponse("PurchaseOrder/Update_PurchaseOrderHeader", "updateParameter=" + JsonConvert.SerializeObject(updateParameter, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static Update_PurchaseOrderItemResponse Add_PurchaseOrderItem(Add_PurchaseOrderItemParameter addItemParameter, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<Update_PurchaseOrderItemResponse>(Factory.GetResponse("PurchaseOrder/Add_PurchaseOrderItem", "addItemParameter=" + JsonConvert.SerializeObject(addItemParameter, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static Update_PurchaseOrderItemResponse Update_PurchaseOrderItem(Update_PurchaseOrderItemParameter updateItemParameter, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<Update_PurchaseOrderItemResponse>(Factory.GetResponse("PurchaseOrder/Update_PurchaseOrderItem", "updateItemParameter=" + JsonConvert.SerializeObject(updateItemParameter, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static PurchaseOrderHeader Delete_PurchaseOrderItem(Delete_PurchaseOrderItemParameter deleteItemParameter, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<PurchaseOrderHeader>(Factory.GetResponse("PurchaseOrder/Delete_PurchaseOrderItem", "deleteItemParameter=" + JsonConvert.SerializeObject(deleteItemParameter, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<Guid> GetPurchaseOrdersWithStockItems(PurchaseOrderWithStockItem purchaseOrder, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<Guid>>(Factory.GetResponse("PurchaseOrder/GetPurchaseOrdersWithStockItems", "purchaseOrder=" + JsonConvert.SerializeObject(purchaseOrder, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static Get_PurchaseOrderResponse Get_PurchaseOrder(Guid pkPurchaseId, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<Get_PurchaseOrderResponse>(Factory.GetResponse("PurchaseOrder/Get_PurchaseOrder", "pkPurchaseId=" + pkPurchaseId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<PurchaseOrderNote> Get_PurchaseOrderNote(Guid pkPurchaseId, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<PurchaseOrderNote>>(Factory.GetResponse("PurchaseOrder/Get_PurchaseOrderNote", "pkPurchaseId=" + pkPurchaseId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static PurchaseOrderNote Add_PurchaseOrderNote(Guid pkPurchaseId, string Note, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<PurchaseOrderNote>(Factory.GetResponse("PurchaseOrder/Add_PurchaseOrderNote", "pkPurchaseId=" + pkPurchaseId + "&Note=" + Note + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static int Delete_PurchaseOrderNote(Guid pkPurchaseId, Guid pkPurchaseOrderNoteId, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<int>(Factory.GetResponse("PurchaseOrder/Delete_PurchaseOrderNote", "pkPurchaseId=" + pkPurchaseId + "&pkPurchaseOrderNoteId=" + pkPurchaseOrderNoteId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static PurchaseOrderHeader Change_PurchaseOrderStatus(Change_PurchaseOrderStatusParameter changeStatusParameter, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<PurchaseOrderHeader>(Factory.GetResponse("PurchaseOrder/Change_PurchaseOrderStatus", "changeStatusParameter=" + JsonConvert.SerializeObject(changeStatusParameter, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

<<<<<<< HEAD
        public static Deliver_PurchaseOrderItemAllResponse Deliver_PurchaseItemAll(Guid purchaseId, string ApiToken, string ApiServer)
=======
        public static Deliver_PurchaseOrderItemAllNoBatchResponse Deliver_PurchaseItemAll_ExceptBatchItems(Guid purchaseId, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Deliver_PurchaseOrderItemAllNoBatchResponse>(Factory.GetResponse("PurchaseOrder/Deliver_PurchaseItemAll_ExceptBatchItems", "purchaseId=" + purchaseId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static Deliver_PurchaseOrderItemAllResponse Deliver_PurchaseItemAll(Guid purchaseId, String ApiToken, String ApiServer)
>>>>>>> refs/remotes/LinnSystems/master
        {
            return JsonConvert.DeserializeObject<Deliver_PurchaseOrderItemAllResponse>(Factory.GetResponse("PurchaseOrder/Deliver_PurchaseItemAll", "purchaseId=" + purchaseId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static Update_PurchaseOrderItemResponse Deliver_PurchaseItem(Deliver_PurchaseItemParameter deliverItemParameter, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<Update_PurchaseOrderItemResponse>(Factory.GetResponse("PurchaseOrder/Deliver_PurchaseItem", "deliverItemParameter=" + JsonConvert.SerializeObject(deliverItemParameter, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<PurchaseOrderStatus> GetPurchaseOrderStatusList(string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<PurchaseOrderStatus>>(Factory.GetResponse("PurchaseOrder/GetPurchaseOrderStatusList", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static void Delete_PurchaseOrder(Guid pkPurchaseId, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("PurchaseOrder/Delete_PurchaseOrder", "pkPurchaseId=" + pkPurchaseId + "", ApiToken, ApiServer);
        }

        public static List<PurchaseOrderAudit> Get_PurchaseOrderAudit(Search_PurchaseOrder_AuditLog auditLog, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<PurchaseOrderAudit>>(Factory.GetResponse("PurchaseOrder/Get_PurchaseOrderAudit", "auditLog=" + JsonConvert.SerializeObject(auditLog, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static Get_PurchaseOrderExtendedPropertyResponse Get_PurchaseOrderExtendedProperty(Get_PurchaseOrderExtendedPropertyRequest request, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Get_PurchaseOrderExtendedPropertyResponse>(Factory.GetResponse("PurchaseOrder/Get_PurchaseOrderExtendedProperty", "request=" + Newtonsoft.Json.JsonConvert.SerializeObject(request, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static Add_PurchaseOrderExtendedPropertyResponse Add_PurchaseOrderExtendedProperty(Add_PurchaseOrderExtendedPropertyRequest request, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Add_PurchaseOrderExtendedPropertyResponse>(Factory.GetResponse("PurchaseOrder/Add_PurchaseOrderExtendedProperty", "request=" + Newtonsoft.Json.JsonConvert.SerializeObject(request, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static void Update_PurchaseOrderExtendedProperty(Update_PurchaseOrderExtendedPropertyRequest request, String ApiToken, String ApiServer)
        {
            Factory.GetResponse("PurchaseOrder/Update_PurchaseOrderExtendedProperty", "request=" + Newtonsoft.Json.JsonConvert.SerializeObject(request, serializerSettings) + "", ApiToken, ApiServer);
        }

        public static void Delete_PurchaseOrderExtendedProperty(Delete_PurchaseOrderExtendedPropertyRequest request, String ApiToken, String ApiServer)
        {
            Factory.GetResponse("PurchaseOrder/Delete_PurchaseOrderExtendedProperty", "request=" + Newtonsoft.Json.JsonConvert.SerializeObject(request, serializerSettings) + "", ApiToken, ApiServer);
        }
    }
}