using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace LinnworksAPI
{
    public static class InventoryMethods
    {
        private static JsonSerializerSettings serializerSettings = new JsonSerializerSettings() { DateFormatString = "yyyy-MM-ddTHH:mm:ss.ffZ" };

        public static void UpdateSupplier(Supplier supplier, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("Inventory/UpdateSupplier", "supplier=" + JsonConvert.SerializeObject(supplier, serializerSettings) + "", ApiToken, ApiServer);
        }

        public static void DeleteSuppliers(List<Guid> suppliersIds, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("Inventory/DeleteSuppliers", "suppliersIds=" + JsonConvert.SerializeObject(suppliersIds, serializerSettings) + "", ApiToken, ApiServer);
        }

        public static List<StockItemSupplierStat> GetStockSupplierStat(Guid inventoryItemId, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<StockItemSupplierStat>>(Factory.GetResponse("Inventory/GetStockSupplierStat", "inventoryItemId=" + inventoryItemId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static void CreateStockSupplierStat(List<StockItemSupplierStat> itemSuppliers, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("Inventory/CreateStockSupplierStat", "itemSuppliers=" + JsonConvert.SerializeObject(itemSuppliers, serializerSettings) + "", ApiToken, ApiServer);
        }

        public static void UpdateStockSupplierStat(List<StockItemSupplierStat> itemSuppliers, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("Inventory/UpdateStockSupplierStat", "itemSuppliers=" + JsonConvert.SerializeObject(itemSuppliers, serializerSettings) + "", ApiToken, ApiServer);
        }

        public static void DeleteStockSupplierStat(Guid stockItemId, List<Guid> itemSupplierIds, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("Inventory/DeleteStockSupplierStat", "stockItemId=" + stockItemId + "&itemSupplierIds=" + JsonConvert.SerializeObject(itemSupplierIds, serializerSettings) + "", ApiToken, ApiServer);
        }

        public static List<StockItemPrice> GetInventoryItemPrices(Guid inventoryItemId, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<StockItemPrice>>(Factory.GetResponse("Inventory/GetInventoryItemPrices", "inventoryItemId=" + inventoryItemId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static void CreateInventoryItemPrices(List<StockItemPrice> inventoryItemPrices, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("Inventory/CreateInventoryItemPrices", "inventoryItemPrices=" + JsonConvert.SerializeObject(inventoryItemPrices, serializerSettings) + "", ApiToken, ApiServer);
        }

        public static void UpdateInventoryItemPrices(List<StockItemPrice> inventoryItemPrices, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("Inventory/UpdateInventoryItemPrices", "inventoryItemPrices=" + JsonConvert.SerializeObject(inventoryItemPrices, serializerSettings) + "", ApiToken, ApiServer);
        }

        public static void DeleteInventoryItemPrices(List<Guid> inventoryItemPriceIds, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("Inventory/DeleteInventoryItemPrices", "inventoryItemPriceIds=" + JsonConvert.SerializeObject(inventoryItemPriceIds, serializerSettings) + "", ApiToken, ApiServer);
        }

        public static List<StockItemPricingRule> GetInventoryItemPriceRulesById(Guid stockItemPriceId, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<StockItemPricingRule>>(Factory.GetResponse("Inventory/GetInventoryItemPriceRulesById", "stockItemPriceId=" + stockItemPriceId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<StockItemPricingRule> GetInventoryItemPriceRulesBySource(Guid stockItemId, string source, string subSource, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<StockItemPricingRule>>(Factory.GetResponse("Inventory/GetInventoryItemPriceRulesBySource", "stockItemId=" + stockItemId + "&source=" + source + "&subSource=" + subSource + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static void CreateInventoryItemPricingRules(List<StockItemPricingRule> rules, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("Inventory/CreateInventoryItemPricingRules", "rules=" + JsonConvert.SerializeObject(rules, serializerSettings) + "", ApiToken, ApiServer);
        }

        public static void DeleteInventoryItemPricingRules(List<int> pricingRuleIds, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("Inventory/DeleteInventoryItemPricingRules", "pricingRuleIds=" + JsonConvert.SerializeObject(pricingRuleIds, serializerSettings) + "", ApiToken, ApiServer);
        }

        public static void UpdateInventoryItemPricingRules(List<StockItemPricingRule> rules, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("Inventory/UpdateInventoryItemPricingRules", "rules=" + JsonConvert.SerializeObject(rules, serializerSettings) + "", ApiToken, ApiServer);
        }

        public static List<StockItemDescription> GetInventoryItemDescriptions(Guid inventoryItemId, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<StockItemDescription>>(Factory.GetResponse("Inventory/GetInventoryItemDescriptions", "inventoryItemId=" + inventoryItemId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static void CreateInventoryItemDescriptions(List<StockItemDescription> inventoryItemDescriptions, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("Inventory/CreateInventoryItemDescriptions", "inventoryItemDescriptions=" + JsonConvert.SerializeObject(inventoryItemDescriptions, serializerSettings) + "", ApiToken, ApiServer);
        }

        public static void UpdateInventoryItemDescriptions(List<StockItemDescription> inventoryItemDescriptions, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("Inventory/UpdateInventoryItemDescriptions", "inventoryItemDescriptions=" + JsonConvert.SerializeObject(inventoryItemDescriptions, serializerSettings) + "", ApiToken, ApiServer);
        }

        public static void DeleteInventoryItemDescriptions(List<Guid> inventoryItemDescriptionIds, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("Inventory/DeleteInventoryItemDescriptions", "inventoryItemDescriptionIds=" + JsonConvert.SerializeObject(inventoryItemDescriptionIds, serializerSettings) + "", ApiToken, ApiServer);
        }

        public static List<StockItemLabel> GetStockItemLabels(List<Tuple<int, int>> selectedRegions, Guid token, Guid location, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<StockItemLabel>>(Factory.GetResponse("Inventory/GetStockItemLabels", "selectedRegions=" + JsonConvert.SerializeObject(selectedRegions, serializerSettings) + "&token=" + token + "&location=" + location + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<AnyConfig> GetChannels(string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<AnyConfig>>(Factory.GetResponse("Inventory/GetChannels", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<ChannelItem> GetChannelItems(int ChannelID, string Keyword, int Page, bool ShowLinked, int ShowOnPage, bool ShowUnlinked, string Source, string Subsource, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<ChannelItem>>(Factory.GetResponse("ChannelMapping/GetChannelItems", "channelOptions={\"ChannelId\":" + ChannelID + ",\"Keyword\":\"" + Keyword + "\",\"Page\":" + Page + ",\"ShowLinked\":" + "true" + ",\"ShowOnPage\":" + ShowOnPage + ",\"ShowUnlinked\":" + "false" + ",\"Source\":\"" + Source + "\",\"SubSource\":\"" + Subsource + "\"}", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<HeaderConfig> GetChannelsBySource(string source, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<HeaderConfig>>(Factory.GetResponse("Inventory/GetChannelsBySource", "source=" + source + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<string> GetExtendedPropertyNames(string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<string>>(Factory.GetResponse("Inventory/GetExtendedPropertyNames", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<string> GetExtendedPropertyTypes(string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<string>>(Factory.GetResponse("Inventory/GetExtendedPropertyTypes", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<KeyGuidValue> GetPackageGroups(string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<KeyGuidValue>>(Factory.GetResponse("Inventory/GetPackageGroups", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<KeyGuidValue> GetPostalServices(string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<KeyGuidValue>>(Factory.GetResponse("Inventory/GetPostalServices", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static AddImageToInventoryItemResponse AddImageToInventoryItem(AddImageToInventoryItemRequest addImageToInventoryItemRequest, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<AddImageToInventoryItemResponse>(Factory.GetResponse("Inventory/AddImageToInventoryItem", "addImageToInventoryItemRequest=" + JsonConvert.SerializeObject(addImageToInventoryItemRequest, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static PortionResult<InventoryItem> GetInventoryItems(InventoryView view, List<Guid> stockLocationIds, int startIndex, int itemsCount, bool preloadChilds, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<PortionResult<InventoryItem>>(Factory.GetResponse("Inventory/GetInventoryItems", "view=" + JsonConvert.SerializeObject(view, serializerSettings) + "&stockLocationIds=" + JsonConvert.SerializeObject(stockLocationIds, serializerSettings) + "&startIndex=" + startIndex + "&itemsCount=" + itemsCount + "&preloadChilds=" + preloadChilds + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static Dictionary<Guid, List<InventoryItem>> GetInventoryItemsChilds(InventoryView view, List<Guid> stockLocationIds, List<Guid> itemIds, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<Dictionary<Guid, List<InventoryItem>>>(Factory.GetResponse("Inventory/GetInventoryItemsChilds", "view=" + JsonConvert.SerializeObject(view, serializerSettings) + "&stockLocationIds=" + JsonConvert.SerializeObject(stockLocationIds, serializerSettings) + "&itemIds=" + JsonConvert.SerializeObject(itemIds, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static Dictionary<string, object> UpdateInventoryItemField(Guid inventoryItemId, ColumnNameType fieldName, string fieldValue, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<Dictionary<string, object>>(Factory.GetResponse("Inventory/UpdateInventoryItemField", "inventoryItemId=" + inventoryItemId + "&fieldName=" + fieldName + "&fieldValue=" + fieldValue + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static Dictionary<string, object> UpdateInventoryItemStockField(Guid inventoryItemId, ColumnNameType fieldName, string fieldValue, Guid locationId, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<Dictionary<string, object>>(Factory.GetResponse("Inventory/UpdateInventoryItemStockField", "inventoryItemId=" + inventoryItemId + "&fieldName=" + fieldName + "&fieldValue=" + fieldValue + "&locationId=" + locationId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static Dictionary<string, object> UpdateInventoryItemLocationField(Guid inventoryItemId, ColumnNameType fieldName, string fieldValue, Guid locationId, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<Dictionary<string, object>>(Factory.GetResponse("Inventory/UpdateInventoryItemLocationField", "inventoryItemId=" + inventoryItemId + "&fieldName=" + fieldName + "&fieldValue=" + fieldValue + "&locationId=" + locationId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static StockItemInv GetInventoryItemById(Guid id, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<StockItemInv>(Factory.GetResponse("Inventory/GetInventoryItemById", "id=" + id + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<InventoryView> GetUserSpecificViews(string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<InventoryView>>(Factory.GetResponse("Inventory/GetUserSpecificViews", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static void CreateUserSpecificView(InventoryView view, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("Inventory/CreateUserSpecificView", "view=" + JsonConvert.SerializeObject(view, serializerSettings) + "", ApiToken, ApiServer);
        }

        public static void UpdateUserSpecificView(string viewName, InventoryView view, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("Inventory/UpdateUserSpecificView", "viewName=" + viewName + "&view=" + JsonConvert.SerializeObject(view, serializerSettings) + "", ApiToken, ApiServer);
        }

        public static void DeleteUserSpecificView(string viewName, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("Inventory/DeleteUserSpecificView", "viewName=" + viewName + "", ApiToken, ApiServer);
        }

        public static List<InventoryView> GetPreDefinedViews(string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<InventoryView>>(Factory.GetResponse("Inventory/GetPreDefinedViews", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static int GetInventoryItemsCount(bool? includeDeleted, bool? includeArchived, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<int>(Factory.GetResponse("Inventory/GetInventoryItemsCount", "includeDeleted=" + JsonConvert.SerializeObject(includeDeleted, serializerSettings) + "&includeArchived=" + JsonConvert.SerializeObject(includeArchived, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static void AddInventoryItem(StockItem inventoryItem, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("Inventory/AddInventoryItem", "inventoryItem=" + JsonConvert.SerializeObject(inventoryItem, serializerSettings) + "", ApiToken, ApiServer);
        }

        public static void DuplicateInventoryItem(StockItem inventoryItem, Guid sourceItemId, bool copyImages, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("Inventory/DuplicateInventoryItem", "inventoryItem=" + JsonConvert.SerializeObject(inventoryItem, serializerSettings) + "&sourceItemId=" + sourceItemId + "&copyImages=" + copyImages + "", ApiToken, ApiServer);
        }

        public static void ArchiveInventoryItems(InventoryParameters parameters, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("Inventory/ArchiveInventoryItems", "parameters=" + JsonConvert.SerializeObject(parameters, serializerSettings) + "", ApiToken, ApiServer);
        }

        public static void UnarchiveInventoryItems(InventoryParameters parameters, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("Inventory/UnarchiveInventoryItems", "parameters=" + JsonConvert.SerializeObject(parameters, serializerSettings) + "", ApiToken, ApiServer);
        }

        public static string GetNewItemNumber(string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<string>(Factory.GetResponse("Inventory/GetNewItemNumber", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static void UpdateInventoryItem(StockItemInv inventoryItem, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("Inventory/UpdateInventoryItem", "inventoryItem=" + JsonConvert.SerializeObject(inventoryItem, serializerSettings) + "", ApiToken, ApiServer);
        }

        public static void DeleteInventoryItems(IEnumerable<Guid> inventoryItemIds, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("Inventory/DeleteInventoryItems", "inventoryItemIds=" + JsonConvert.SerializeObject(inventoryItemIds, serializerSettings) + "", ApiToken, ApiServer);
        }

        public static void AdjustTemplatesInstant(IEnumerable<Guid> inventoryItemIds, string source, string subSource, AdjustmentOptions adjustmentOptions, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("Inventory/AdjustTemplatesInstant", "inventoryItemIds=" + JsonConvert.SerializeObject(inventoryItemIds, serializerSettings) + "&source=" + source + "&subSource=" + subSource + "&adjustmentOptions=" + JsonConvert.SerializeObject(adjustmentOptions, serializerSettings) + "", ApiToken, ApiServer);
        }

        public static List<StockItemChannelSKU> GetInventoryItemChannelSKUs(Guid inventoryItemId, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<StockItemChannelSKU>>(Factory.GetResponse("Inventory/GetInventoryItemChannelSKUs", "inventoryItemId=" + inventoryItemId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static void UpdateInventoryItemChannelSKUs(List<StockItemChannelSKU> inventoryItemChannelSKUs, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("Inventory/UpdateInventoryItemChannelSKUs", "inventoryItemChannelSKUs=" + JsonConvert.SerializeObject(inventoryItemChannelSKUs, serializerSettings) + "", ApiToken, ApiServer);
        }

        public static void CreateInventoryItemChannelSKUs(List<StockItemChannelSKU> inventoryItemChannelSKUs, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("Inventory/CreateInventoryItemChannelSKUs", "inventoryItemChannelSKUs=" + JsonConvert.SerializeObject(inventoryItemChannelSKUs, serializerSettings) + "", ApiToken, ApiServer);
        }

        public static void DeleteInventoryItemChannelSKUs(List<Guid> inventoryItemChannelSKUIds, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("Inventory/DeleteInventoryItemChannelSKUs", "inventoryItemChannelSKUIds=" + JsonConvert.SerializeObject(inventoryItemChannelSKUIds, serializerSettings) + "", ApiToken, ApiServer);
        }

        public static void UnlinkChannelListing(string channelRefId, string source, string subSource, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("Inventory/UnlinkChannelListing", "channelRefId=" + channelRefId + "&source=" + source + "&subSource=" + subSource + "", ApiToken, ApiServer);
        }

        public static List<StockItemAuditTrail> GetInventoryItemAuditTrail(Guid inventoryItemId, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<StockItemAuditTrail>>(Factory.GetResponse("Inventory/GetInventoryItemAuditTrail", "inventoryItemId=" + inventoryItemId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<StockItemImage> GetInventoryItemImages(Guid inventoryItemId, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<StockItemImage>>(Factory.GetResponse("Inventory/GetInventoryItemImages", "inventoryItemId=" + inventoryItemId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static void SetInventoryItemImageAsMain(Guid inventoryItemId, Guid mainImageId, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("Inventory/SetInventoryItemImageAsMain", "inventoryItemId=" + inventoryItemId + "&mainImageId=" + mainImageId + "", ApiToken, ApiServer);
        }

        public static List<PictureSource> UploadImagesToInventoryItem(Guid inventoryItemId, List<Guid> imageIds, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<PictureSource>>(Factory.GetResponse("Inventory/UploadImagesToInventoryItem", "inventoryItemId=" + inventoryItemId + "&imageIds=" + JsonConvert.SerializeObject(imageIds, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static void UpdateImages(List<StockItemImageSimple> images, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("Inventory/UpdateImages", "images=" + JsonConvert.SerializeObject(images, serializerSettings) + "", ApiToken, ApiServer);
        }

        public static void DeleteImagesFromInventoryItem(Dictionary<Guid, List<string>> inventoryItemImages, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("Inventory/DeleteImagesFromInventoryItem", "inventoryItemImages=" + JsonConvert.SerializeObject(inventoryItemImages, serializerSettings) + "", ApiToken, ApiServer);
        }

        public static List<Category> GetCategories(string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<Category>>(Factory.GetResponse("Inventory/GetCategories", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static Category CreateCategory(string categoryName, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<Category>(Factory.GetResponse("Inventory/CreateCategory", "categoryName=" + categoryName + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static void UpdateCategory(Category category, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("Inventory/UpdateCategory", "category=" + JsonConvert.SerializeObject(category, serializerSettings) + "", ApiToken, ApiServer);
        }

        public static void DeleteCategoryById(Guid categoryId, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("Inventory/DeleteCategoryById", "categoryId=" + categoryId + "", ApiToken, ApiServer);
        }

        public static Dictionary<string, string> GetCountryCodes(string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<Dictionary<string, string>>(Factory.GetResponse("Inventory/GetCountryCodes", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static IEnumerable<Country> GetCountries(string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<IEnumerable<Country>>(Factory.GetResponse("Inventory/GetCountries", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static void CreateCountries(IEnumerable<Country> countries, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("Inventory/CreateCountries", "countries=" + JsonConvert.SerializeObject(countries, serializerSettings) + "", ApiToken, ApiServer);
        }

        public static void UpdateCountries(IEnumerable<Country> countries, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("Inventory/UpdateCountries", "countries=" + JsonConvert.SerializeObject(countries, serializerSettings) + "", ApiToken, ApiServer);
        }

        public static List<StockLocation> GetStockLocations(string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<StockLocation>>(Factory.GetResponse("Inventory/GetStockLocations", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static bool IsOwnedStockLocation(Guid locationId, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<bool>(Factory.GetResponse("Inventory/IsOwnedStockLocation", "locationId=" + locationId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<StockItemLocation> GetInventoryItemLocations(Guid inventoryItemId, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<StockItemLocation>>(Factory.GetResponse("Inventory/GetInventoryItemLocations", "inventoryItemId=" + inventoryItemId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static void AddItemLocations(List<StockItemLocation> itemLocations, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("Inventory/AddItemLocations", "itemLocations=" + JsonConvert.SerializeObject(itemLocations, serializerSettings) + "", ApiToken, ApiServer);
        }

        public static void UpdateItemLocations(List<StockItemLocation> itemLocations, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("Inventory/UpdateItemLocations", "itemLocations=" + JsonConvert.SerializeObject(itemLocations, serializerSettings) + "", ApiToken, ApiServer);
        }

        public static void DeleteItemLocations(Guid inventoryItemId, List<Guid> itemLocations, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("Inventory/DeleteItemLocations", "inventoryItemId=" + inventoryItemId + "&itemLocations=" + JsonConvert.SerializeObject(itemLocations, serializerSettings) + "", ApiToken, ApiServer);
        }

        public static List<StockItemComposition> GetInventoryItemCompositions(Guid inventoryItemId, bool getFullDetail, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<StockItemComposition>>(Factory.GetResponse("Inventory/GetInventoryItemCompositions", "inventoryItemId=" + inventoryItemId + "&getFullDetail=" + getFullDetail + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static void CreateInventoryItemCompositions(List<StockItemComposition> inventoryItemCompositions, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("Inventory/CreateInventoryItemCompositions", "inventoryItemCompositions=" + JsonConvert.SerializeObject(inventoryItemCompositions, serializerSettings) + "", ApiToken, ApiServer);
        }

        public static void UpdateInventoryItemCompositions(List<StockItemComposition> inventoryItemCompositions, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("Inventory/UpdateInventoryItemCompositions", "inventoryItemCompositions=" + JsonConvert.SerializeObject(inventoryItemCompositions, serializerSettings) + "", ApiToken, ApiServer);
        }

        public static void DeleteInventoryItemCompositions(Guid stockItemId, List<Guid> inventoryItemCompositionIds, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("Inventory/DeleteInventoryItemCompositions", "stockItemId=" + stockItemId + "&inventoryItemCompositionIds=" + JsonConvert.SerializeObject(inventoryItemCompositionIds, serializerSettings) + "", ApiToken, ApiServer);
        }

        public static List<StockItemExtendedProperty> GetInventoryItemExtendedProperties(Guid inventoryItemId, GetExtendedPropertyFilter propertyParams, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<StockItemExtendedProperty>>(Factory.GetResponse("Inventory/GetInventoryItemExtendedProperties", "inventoryItemId=" + inventoryItemId + "&propertyParams=" + JsonConvert.SerializeObject(propertyParams, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static void CreateInventoryItemExtendedProperties(List<StockItemExtendedProperty> inventoryItemExtendedProperties, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("Inventory/CreateInventoryItemExtendedProperties", "inventoryItemExtendedProperties=" + JsonConvert.SerializeObject(inventoryItemExtendedProperties, serializerSettings) + "", ApiToken, ApiServer);
        }

        public static void UpdateInventoryItemExtendedProperties(List<StockItemExtendedProperty> inventoryItemExtendedProperties, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("Inventory/UpdateInventoryItemExtendedProperties", "inventoryItemExtendedProperties=" + JsonConvert.SerializeObject(inventoryItemExtendedProperties, serializerSettings) + "", ApiToken, ApiServer);
        }

        public static void DeleteInventoryItemExtendedProperties(Guid inventoryItemId, List<Guid> inventoryItemExtendedPropertyIds, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("Inventory/DeleteInventoryItemExtendedProperties", "inventoryItemId=" + inventoryItemId + "&inventoryItemExtendedPropertyIds=" + JsonConvert.SerializeObject(inventoryItemExtendedPropertyIds, serializerSettings) + "", ApiToken, ApiServer);
        }

        public static List<StockItemTitle> GetInventoryItemTitles(Guid inventoryItemId, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<StockItemTitle>>(Factory.GetResponse("Inventory/GetInventoryItemTitles", "inventoryItemId=" + inventoryItemId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static void CreateInventoryItemTitles(List<StockItemTitle> inventoryItemTitles, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("Inventory/CreateInventoryItemTitles", "inventoryItemTitles=" + JsonConvert.SerializeObject(inventoryItemTitles, serializerSettings) + "", ApiToken, ApiServer);
        }

        public static void UpdateInventoryItemTitles(List<StockItemTitle> inventoryItemTitles, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("Inventory/UpdateInventoryItemTitles", "inventoryItemTitles=" + JsonConvert.SerializeObject(inventoryItemTitles, serializerSettings) + "", ApiToken, ApiServer);
        }

        public static void DeleteInventoryItemTitles(List<Guid> inventoryItemTitleIds, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("Inventory/DeleteInventoryItemTitles", "inventoryItemTitleIds=" + JsonConvert.SerializeObject(inventoryItemTitleIds, serializerSettings) + "", ApiToken, ApiServer);
        }

        public static List<Supplier> GetSuppliers(string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<Supplier>>(Factory.GetResponse("Inventory/GetSuppliers", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static Supplier GetSupplierDetails(Guid supplierId, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<Supplier>(Factory.GetResponse("Inventory/GetSupplierDetails", "supplierId=" + supplierId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static Supplier AddSupplier(Supplier supplier, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<Supplier>(Factory.GetResponse("Inventory/AddSupplier", "supplier=" + JsonConvert.SerializeObject(supplier, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }
    }
}