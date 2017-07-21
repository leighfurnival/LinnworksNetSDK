namespace LinnworksAPI
{
    //ReSharper disable UnusedMember.Global
    public class ChannelItem
    {
        public string SKU { get; set; }
        public bool FBA { get; set; }
        public string ChannelReferenceId { get; set; }
        public bool IgnoreSync { get; set; }
        public bool IsLinked { get; set; }
        public bool IsSuggestedToLink { get; set; }
        public bool IsMatchByTitle { get; set; }
        public double StockPercentage { get; set; }
        public string LinkedItemId { get; set; }
        public int EndWhenStock { get; set; }
        public int MaxListedQuantity { get; set; }
        public string LinkedItemSku { get; set; }
        public string LinkedItemTitle { get; set; }
        public string Title { get; set; }
        public int Quantity { get; set; }
    }
}
