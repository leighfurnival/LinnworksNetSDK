using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace LinnworksAPI
{
    public static class WarehouseTransferMethods
    {
        private static JsonSerializerSettings serializerSettings = new JsonSerializerSettings() { DateFormatString = "yyyy-MM-ddTHH:mm:ss.ffZ" };

        public static List<WarehouseTransfer> GetActiveTransfersForLocation(Guid locationId, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<WarehouseTransfer>>(Factory.GetResponse("WarehouseTransfer/GetActiveTransfersForLocation", "locationId=" + locationId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<WarehouseTransfer> GetActiveTransfersAllLocations(string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<WarehouseTransfer>>(Factory.GetResponse("WarehouseTransfer/GetActiveTransfersAllLocations", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static WarehouseTransfer CreateTransferRequestWithReturn(Guid fromLocationId, Guid toLocationId, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<WarehouseTransfer>(Factory.GetResponse("WarehouseTransfer/CreateTransferRequestWithReturn", "fromLocationId=" + fromLocationId + "&toLocationId=" + toLocationId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static WarehouseTransfer CreateTransferFromDescrepancies(Guid pkTransferId, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<WarehouseTransfer>(Factory.GetResponse("WarehouseTransfer/CreateTransferFromDescrepancies", "pkTransferId=" + pkTransferId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static void DeleteTransfer(Guid pkTransferId, string DeleteReason, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("WarehouseTransfer/DeleteTransfer", "pkTransferId=" + pkTransferId + "&DeleteReason=" + DeleteReason + "", ApiToken, ApiServer);
        }

        public static void DeleteTransferProperty(Guid pkTransferId, Guid pkTransferPropertyId, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("WarehouseTransfer/DeleteTransferProperty", "pkTransferId=" + pkTransferId + "&pkTransferPropertyId=" + pkTransferPropertyId + "", ApiToken, ApiServer);
        }

        public static WarehouseTransfer GetTransferWithNotes(Guid pkTransferId, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<WarehouseTransfer>(Factory.GetResponse("WarehouseTransfer/GetTransferWithNotes", "pkTransferId=" + pkTransferId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static void ChangeTransferStatus(Guid pkTransferId, TransferStatus newStatus, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("WarehouseTransfer/ChangeTransferStatus", "pkTransferId=" + pkTransferId + "&newStatus=" + newStatus + "", ApiToken, ApiServer);
        }

        public static Guid AddTransferNote(Guid pkTransferId, string note, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<Guid>(Factory.GetResponse("WarehouseTransfer/AddTransferNote", "pkTransferId=" + pkTransferId + "&note=" + note + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static Guid AddTransferBinNote(Guid fkTransferBinId, string note, Guid fkTransferId, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<Guid>(Factory.GetResponse("WarehouseTransfer/AddTransferBinNote", "fkTransferBinId=" + fkTransferBinId + "&note=" + note + "&fkTransferId=" + fkTransferId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static WarehouseTransferItem AddItemToTransfer(Guid fkTransferId, Guid pkStockItemId, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<WarehouseTransferItem>(Factory.GetResponse("WarehouseTransfer/AddItemToTransfer", "fkTransferId=" + fkTransferId + "&pkStockItemId=" + pkStockItemId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static Guid AddTransferProperty(Guid fkTransferId, string propertyName, string propertyValue, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<Guid>(Factory.GetResponse("WarehouseTransfer/AddTransferProperty", "fkTransferId=" + fkTransferId + "&propertyName=" + propertyName + "&propertyValue=" + propertyValue + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static void RemoveItemFromTransfer(Guid pkTransferId, Guid pkTransferItemId, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("WarehouseTransfer/RemoveItemFromTransfer", "pkTransferId=" + pkTransferId + "&pkTransferItemId=" + pkTransferItemId + "", ApiToken, ApiServer);
        }

        public static void SetReferenceNumber(Guid pkTransferId, string ReferenceNumber, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("WarehouseTransfer/SetReferenceNumber", "pkTransferId=" + pkTransferId + "&ReferenceNumber=" + ReferenceNumber + "", ApiToken, ApiServer);
        }

        public static void ChangeTransferFromLocation(Guid pkTransferId, Guid newLocationId, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("WarehouseTransfer/ChangeTransferFromLocation", "pkTransferId=" + pkTransferId + "&newLocationId=" + newLocationId + "", ApiToken, ApiServer);
        }

        public static void ChangeTransferToLocation(Guid pkTransferId, Guid newLocationId, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("WarehouseTransfer/ChangeTransferToLocation", "pkTransferId=" + pkTransferId + "&newLocationId=" + newLocationId + "", ApiToken, ApiServer);
        }

        public static void ChangeTransferLocations(Guid pkTransferId, Guid fromLocationId, Guid toLocationId, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("WarehouseTransfer/ChangeTransferLocations", "pkTransferId=" + pkTransferId + "&fromLocationId=" + fromLocationId + "&toLocationId=" + toLocationId + "", ApiToken, ApiServer);
        }

        public static void ChangeTransferProperty(Guid pkTransferId, Guid pkTransferPropertyId, string newValue, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("WarehouseTransfer/ChangeTransferProperty", "pkTransferId=" + pkTransferId + "&pkTransferPropertyId=" + pkTransferPropertyId + "&newValue=" + newValue + "", ApiToken, ApiServer);
        }

        public static List<WarehouseTransferItem> GetTransferItems(Guid pkTransferId, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<WarehouseTransferItem>>(Factory.GetResponse("WarehouseTransfer/GetTransferItems", "pkTransferId=" + pkTransferId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static void ChangeTransferItemRequestQuantity(Guid pkTransferId, Guid pkTransferItemId, int Quantity, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("WarehouseTransfer/ChangeTransferItemRequestQuantity", "pkTransferId=" + pkTransferId + "&pkTransferItemId=" + pkTransferItemId + "&Quantity=" + Quantity + "", ApiToken, ApiServer);
        }

        public static WarehouseTransferItem ChangeTransferItemSentQuantity(Guid pkTransferId, Guid pkBinId, Guid pkTransferItemId, int Quantity, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<WarehouseTransferItem>(Factory.GetResponse("WarehouseTransfer/ChangeTransferItemSentQuantity", "pkTransferId=" + pkTransferId + "&pkBinId=" + pkBinId + "&pkTransferItemId=" + pkTransferItemId + "&Quantity=" + Quantity + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static void ChangeTransferItemReceivedQuantity(Guid pkTransferId, Guid pkBinId, Guid pkTransferItemId, int? Quantity, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("WarehouseTransfer/ChangeTransferItemReceivedQuantity", "pkTransferId=" + pkTransferId + "&pkBinId=" + pkBinId + "&pkTransferItemId=" + pkTransferItemId + "&Quantity=" + JsonConvert.SerializeObject(Quantity, serializerSettings) + "", ApiToken, ApiServer);
        }

        public static List<WarehouseTransferNote> GetTransferNotes(Guid pkTransferId, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<WarehouseTransferNote>>(Factory.GetResponse("WarehouseTransfer/GetTransferNotes", "pkTransferId=" + pkTransferId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<WarehouseTransferItemNote> GetTransferItemNotes(Guid pkTransferId, Guid pkTransferItemId, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<WarehouseTransferItemNote>>(Factory.GetResponse("WarehouseTransfer/GetTransferItemNotes", "pkTransferId=" + pkTransferId + "&pkTransferItemId=" + pkTransferItemId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static Guid AddTransferItemNote(Guid fkTransferId, Guid fkTransferItemId, string note, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<Guid>(Factory.GetResponse("WarehouseTransfer/AddTransferItemNote", "fkTransferId=" + fkTransferId + "&fkTransferItemId=" + fkTransferItemId + "&note=" + note + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<WarehouseTransferAudit> GetTransferAudit(Guid pkTransferId, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<WarehouseTransferAudit>>(Factory.GetResponse("WarehouseTransfer/GetTransferAudit", "pkTransferId=" + pkTransferId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<WarehouseTransferProperty> GetTransferProperties(Guid pkTransferId, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<WarehouseTransferProperty>>(Factory.GetResponse("WarehouseTransfer/GetTransferProperties", "pkTransferId=" + pkTransferId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<Guid> SearchTransfersAllLocations(SearchType searchType, string searchText, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<Guid>>(Factory.GetResponse("WarehouseTransfer/SearchTransfersAllLocations", "searchType=" + searchType + "&searchText=" + searchText + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static GenericPagedResult<WarehouseTransfer> GetArchivedTransfers(int pageNumber, int entriesPerPage, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<GenericPagedResult<WarehouseTransfer>>(Factory.GetResponse("WarehouseTransfer/GetArchivedTransfers", "pageNumber=" + pageNumber + "&entriesPerPage=" + entriesPerPage + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static GenericPagedResult<WarehouseTransfer> GetArchivedTransfersFiltered(SearchType searchType, string filter, int pageNumber, int entriesPerPage, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<GenericPagedResult<WarehouseTransfer>>(Factory.GetResponse("WarehouseTransfer/GetArchivedTransfersFiltered", "searchType=" + searchType + "&filter=" + filter + "&pageNumber=" + pageNumber + "&entriesPerPage=" + entriesPerPage + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static GenericPagedResult<WarehouseTransfer> GetArchivedTransfersBetweenDates(DateTime start, DateTime end, int pageNumber, int entriesPerPage, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<GenericPagedResult<WarehouseTransfer>>(Factory.GetResponse("WarehouseTransfer/GetArchivedTransfersBetweenDates", "start=" + JsonConvert.SerializeObject(start, serializerSettings) + "&end=" + JsonConvert.SerializeObject(end, serializerSettings) + "&pageNumber=" + pageNumber + "&entriesPerPage=" + entriesPerPage + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<Guid> SearchTransfersByLocation(SearchType searchType, string searchText, Guid locationID, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<Guid>>(Factory.GetResponse("WarehouseTransfer/SearchTransfersByLocation", "searchType=" + searchType + "&searchText=" + searchText + "&locationID=" + locationID + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<WarehouseTransfer> GetListTransfers(List<Guid> ids, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<WarehouseTransfer>>(Factory.GetResponse("WarehouseTransfer/GetListTransfers", "ids=" + JsonConvert.SerializeObject(ids, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<WarehouseTransfer> GetModifiedBasic(DateTime updateDate, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<WarehouseTransfer>>(Factory.GetResponse("WarehouseTransfer/GetModifiedBasic", "updateDate=" + JsonConvert.SerializeObject(updateDate, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static DateTime GetServerTime(string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<DateTime>(Factory.GetResponse("WarehouseTransfer/GetServerTime", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static WarehouseTransfer GetTransferWithItems(Guid pkTransferId, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<WarehouseTransfer>(Factory.GetResponse("WarehouseTransfer/GetTransferWithItems", "pkTransferId=" + pkTransferId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static void ChangeBinDetails(Guid pkTransferId, Guid pkBinId, string BinName, string BinReference, string BinBarcode, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("WarehouseTransfer/ChangeBinDetails", "pkTransferId=" + pkTransferId + "&pkBinId=" + pkBinId + "&BinName=" + BinName + "&BinReference=" + BinReference + "&BinBarcode=" + BinBarcode + "", ApiToken, ApiServer);
        }

        public static int AllocateItemToBin(Guid pkSrcBinId, Guid pkDstBinId, Guid pkTransferItemId, int quantity, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<int>(Factory.GetResponse("WarehouseTransfer/AllocateItemToBin", "pkSrcBinId=" + pkSrcBinId + "&pkDstBinId=" + pkDstBinId + "&pkTransferItemId=" + pkTransferItemId + "&quantity=" + quantity + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static WarehouseTransferBin CreateNewBin(Guid pkTransferId, string barcode, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<WarehouseTransferBin>(Factory.GetResponse("WarehouseTransfer/CreateNewBin", "pkTransferId=" + pkTransferId + "&barcode=" + barcode + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static void RemoveAllEmptyBins(string ApiToken, string ApiServer)
        {
            Factory.GetResponse("WarehouseTransfer/RemoveAllEmptyBins", "", ApiToken, ApiServer);
        }

        public static List<WarehouseTransferBinNote> GetTransferBinNotes(Guid pkBinId, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<WarehouseTransferBinNote>>(Factory.GetResponse("WarehouseTransfer/GetTransferBinNotes", "pkBinId=" + pkBinId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<WarehouseTransferItem> GetDiscrepancyItems(Guid pkTransferId, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<WarehouseTransferItem>>(Factory.GetResponse("WarehouseTransfer/GetDiscrepancyItems", "pkTransferId=" + pkTransferId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<StockAvailability> GetStockAvailability(Guid pkTransferItemId, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<StockAvailability>>(Factory.GetResponse("WarehouseTransfer/GetStockAvailability", "pkTransferItemId=" + pkTransferItemId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static bool IsDraftTransferChanged(Guid pkTransferId, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<bool>(Factory.GetResponse("WarehouseTransfer/IsDraftTransferChanged", "pkTransferId=" + pkTransferId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static void DeleteEmptyDraftTransfer(Guid pkTransferId, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("WarehouseTransfer/DeleteEmptyDraftTransfer", "pkTransferId=" + pkTransferId + "", ApiToken, ApiServer);
        }

        public static Guid CheckForDraftTransfer(Guid toLocationId, Guid fromLocationId, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<Guid>(Factory.GetResponse("WarehouseTransfer/CheckForDraftTransfer", "toLocationId=" + toLocationId + "&fromLocationId=" + fromLocationId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static string PrintTransfer(Guid pkTransferId, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<string>(Factory.GetResponse("WarehouseTransfer/PrintTransfer", "pkTransferId=" + pkTransferId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }
    }
}