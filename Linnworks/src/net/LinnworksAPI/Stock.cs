using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace LinnworksAPI
{
    public static class StockMethods
    {
        private static JsonSerializerSettings serializerSettings = new JsonSerializerSettings() { DateFormatString = "yyyy-MM-ddTHH:mm:ss.ffZ" };

        public static VariationParentStatus CheckVariationParentSKUExists(string parentSKU, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<VariationParentStatus>(Factory.GetResponse("Stock/CheckVariationParentSKUExists", "parentSKU=" + parentSKU + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<GenericEnumDescriptor> GetVariationGroupSearchTypes(string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<GenericEnumDescriptor>>(Factory.GetResponse("Stock/GetVariationGroupSearchTypes", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static GenericPagedResult<VariationGroup> SearchVariationGroups(VariationSearchType searchType, string searchText, int pageNumber, int entriesPerPage, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<GenericPagedResult<VariationGroup>>(Factory.GetResponse("Stock/SearchVariationGroups", "searchType=" + JsonConvert.SerializeObject(searchType, serializerSettings) + "&searchText=" + searchText + "&pageNumber=" + pageNumber + "&entriesPerPage=" + entriesPerPage + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static void DeleteVariationGroup(Guid pkVariationGroupId, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("Stock/DeleteVariationGroup", "pkVariationGroupId=" + pkVariationGroupId + "", ApiToken, ApiServer);
        }

        public static VariationGroup GetVariationGroupByParentId(Guid pkStockItemId, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<VariationGroup>(Factory.GetResponse("Stock/GetVariationGroupByParentId", "pkStockItemId=" + pkStockItemId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static VariationGroup GetVariationGroupByName(string variationName, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<VariationGroup>(Factory.GetResponse("Stock/GetVariationGroupByName", "variationName=" + variationName + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static void RenameVariationGroup(Guid pkVariationItemId, string variationName, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("Stock/RenameVariationGroup", "pkVariationItemId=" + pkVariationItemId + "&variationName=" + variationName + "", ApiToken, ApiServer);
        }

        public static List<VariationItem> GetVariationItems(Guid pkVariationItemId, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<VariationItem>>(Factory.GetResponse("Stock/GetVariationItems", "pkVariationItemId=" + pkVariationItemId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<VariationItem> AddVariationItems(Guid pkVariationItemId, List<Guid> pkStockItemIds, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<VariationItem>>(Factory.GetResponse("Stock/AddVariationItems", "pkVariationItemId=" + pkVariationItemId + "&pkStockItemIds=" + JsonConvert.SerializeObject(pkStockItemIds, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static void DeleteVariationItem(Guid pkVariationItemId, Guid pkStockItemId, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("Stock/DeleteVariationItem", "pkVariationItemId=" + pkVariationItemId + "&pkStockItemId=" + pkStockItemId + "", ApiToken, ApiServer);
        }

        public static VariationGroup CreateVariationGroup(VariationGroupTemplate template, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<VariationGroup>(Factory.GetResponse("Stock/CreateVariationGroup", "template=" + JsonConvert.SerializeObject(template, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static bool SKUExists(string SKU, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<bool>(Factory.GetResponse("Stock/SKUExists", "SKU=" + SKU + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<StockConsumption> GetStockConsumption(Guid stockItemId, Guid? locationId, DateTime startDate, DateTime endDate, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<StockConsumption>>(Factory.GetResponse("Stock/GetStockConsumption", "stockItemId=" + stockItemId + "&locationId=" + JsonConvert.SerializeObject(locationId, serializerSettings) + "&startDate=" + JsonConvert.SerializeObject(startDate, serializerSettings) + "&endDate=" + JsonConvert.SerializeObject(endDate, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static GenericPagedResult<StockItemChangeHistory> GetItemChangesHistory(Guid stockItemId, Guid locationId, int entriesPerPage, int pageNumber, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<GenericPagedResult<StockItemChangeHistory>>(Factory.GetResponse("Stock/GetItemChangesHistory", "stockItemId=" + stockItemId + "&locationId=" + locationId + "&entriesPerPage=" + entriesPerPage + "&pageNumber=" + pageNumber + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static TempFile GetItemChangesHistoryCSV(Guid stockItemId, Guid locationId, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<TempFile>(Factory.GetResponse("Stock/GetItemChangesHistoryCSV", "stockItemId=" + stockItemId + "&locationId=" + locationId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static GenericPagedResult<StockItem> GetStockItems(string keyWord, Guid? locationId, int entriesPerPage, int pageNumber, bool excludeComposites, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<GenericPagedResult<StockItem>>(Factory.GetResponse("Stock/GetStockItems", "keyWord=" + keyWord + "&locationId=" + JsonConvert.SerializeObject(locationId, serializerSettings) + "&entriesPerPage=" + entriesPerPage + "&pageNumber=" + pageNumber + "&excludeComposites=" + excludeComposites + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<StockItem> GetStockItemsByKey(Search_Stock_ByKey stockIdentifier, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<StockItem>>(Factory.GetResponse("Stock/GetStockItemsByKey", "stockIdentifier=" + JsonConvert.SerializeObject(stockIdentifier, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<StockItemFull> GetStockItemsFull(string keyword, bool loadCompositeParents, bool loadVariationParents, int entriesPerPage, int pageNumber, List<StockInformationDataRequirement> dataRequirements, List<StockInformationSearchType> searchTypes, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<StockItemFull>>(Factory.GetResponse("Stock/GetStockItemsFull", "keyword=" + keyword + "&loadCompositeParents=" + loadCompositeParents + "&loadVariationParents=" + loadVariationParents + "&entriesPerPage=" + entriesPerPage + "&pageNumber=" + pageNumber + "&dataRequirements=" + JsonConvert.SerializeObject(dataRequirements, serializerSettings) + "&searchTypes=" + JsonConvert.SerializeObject(searchTypes, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<StockItemLevel> GetStockLevel(Guid stockItemId, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<StockItemLevel>>(Factory.GetResponse("Stock/GetStockLevel", "stockItemId=" + stockItemId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static void UpdateStockMinimumLevel(Guid stockItemId, Guid locationId, int minimumLevel, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("Stock/UpdateStockMinimumLevel", "stockItemId=" + stockItemId + "&locationId=" + locationId + "&minimumLevel=" + minimumLevel + "", ApiToken, ApiServer);
        }

        public static List<StockItemSold> GetStockSold(Guid stockItemId, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<StockItemSold>>(Factory.GetResponse("Stock/GetStockSold", "stockItemId=" + stockItemId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<StockItemDuePO> GetStockDuePO(Guid stockItemId, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<StockItemDuePO>>(Factory.GetResponse("Stock/GetStockDuePO", "stockItemId=" + stockItemId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<StockItemReturn> GetStockItemReturnStat(Guid stockItemId, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<StockItemReturn>>(Factory.GetResponse("Stock/GetStockItemReturnStat", "stockItemId=" + stockItemId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<StockItemScrap> GetStockItemScrapStat(Guid stockItemId, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<StockItemScrap>>(Factory.GetResponse("Stock/GetStockItemScrapStat", "stockItemId=" + stockItemId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<StockItemSoldStat> GetSoldStat(Guid stockItemId, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<StockItemSoldStat>>(Factory.GetResponse("Stock/GetSoldStat", "stockItemId=" + stockItemId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<StockItemLevel> SetStockLevel(List<StockLevelUpdate> stockLevels, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<StockItemLevel>>(Factory.GetResponse("Stock/SetStockLevel", "stockLevels=" + JsonConvert.SerializeObject(stockLevels, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<StockItemLevel> UpdateStockLevelsBySKU(List<StockLevelUpdate> stockLevels, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<StockItemLevel>>(Factory.GetResponse("Stock/UpdateStockLevelsBySKU", "stockLevels=" + JsonConvert.SerializeObject(stockLevels, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static void Update_StockItemPartial(PartialUpdateParameter update, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("Stock/Update_StockItemPartial", "update=" + JsonConvert.SerializeObject(update, serializerSettings) + "", ApiToken, ApiServer);
        }

        public static void BookInStockItem(BookInStockItem stockItem, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("Stock/BookInStockItem", "stockItem=" + JsonConvert.SerializeObject(stockItem, serializerSettings) + "", ApiToken, ApiServer);
        }
    }
}