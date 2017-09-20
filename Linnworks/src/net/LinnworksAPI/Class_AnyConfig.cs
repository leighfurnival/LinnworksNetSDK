using System;
using System.Collections.Generic;
//ReSharper disable UnusedMember.Global
namespace LinnworksAPI
{
    public class AnyConfig
    {
<<<<<<< HEAD
        public ConfigItem<bool> Enabled;
        public ConfigItem<string> ChannelTag;
        public ConfigChannelLocationBinding ChannelLocationBinding;
        public ConfigItem<bool> IsMultiLocation;
        public ConfigItem<bool> DespatchNotes;
        public ConfigItem<DateTime> OrderSyncDate;
        public ConfigPropertySelectionList<SelectStringValueOption, Guid> OrderSaveLocation;
        public ConfigProperty<bool> HidesHeaderAttributes;
        public ConfigItem<bool> InventorySync;
=======
        public ConfigItem<String> SourceVersion;
        public ConfigItem<Boolean> Enabled;
        public ConfigItem<String> ChannelTag;
        public ConfigChannelLocationBinding ChannelLocationBinding;
        public ConfigItem<Boolean> IsMultiLocation;
        public ConfigItem<Boolean> DespatchNotes;
        public ConfigItem<Boolean> CancellationNotes;
        public ConfigItem<Boolean> RefundNotes;
        public ConfigItem<Boolean> ReturnNotes;
        public ConfigItem<DateTime> OrderSyncDate;
        public ConfigPropertySelectionList<SelectStringValueOption, Guid> OrderSaveLocation;
        public ConfigPropertySelectionList<SelectStringValueOption, String> ConfigDiscount;
        public ConfigProperty<Boolean> HidesHeaderAttributes;
        public ConfigItem<Boolean> InventorySync;
>>>>>>> refs/remotes/LinnSystems/master
        public ConfigStockLocationBinding StockLocationBinding;
        public ConfigItem<bool> PriceChange;
        public ConfigItem<int> MaxListed;
        public ConfigItem<double> StockPercentage;
        public ConfigItem<int> EndWhen;
        public ConfigItem<bool> IsListingScanRunning;
        public ConfigItem<DateTime> ListingScanStartUpdateDate;
        public ConfigItem<DateTime> LastListingUpdateDate;
        public ConfigItem<DateTime> EstimatedInventoryScanComplete;
        public bool IsHeaderOnly;
        public bool IsHidden;
        public ConfigItemExternal DynamicProperties;
        public DiscountType ConfigDiscountTyped;
        public ConfigPostalServiceMapping PostalServiceMapping;
        public ConfigPaymentMethodMapping PaymentMethodMapping;
        public int PkChannelId;
        public string Source;
        public string SourceType;
        public ConfigRuleCollection Rules;
        public List<ConfigButton> Buttons;
        public string SubSource;
        public List<System_Channel_Setting_Property> HeaderAuditValues;
    }
}