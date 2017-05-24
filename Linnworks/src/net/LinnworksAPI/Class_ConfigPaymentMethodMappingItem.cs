using System;

namespace LinnworksAPI
{
    public class ConfigPaymentMethodMappingItem
    {
        public int fkChannelId;
        public int pkRowId;
        public string Tag;
        public Guid fkBankId;
        public string PaymentMethodName;
        public string Site;
        public bool IsChanged;
    }
}