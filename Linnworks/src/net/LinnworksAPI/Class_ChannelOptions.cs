namespace LinnworksAPI
{
    public class ChannelOptions
    {
        public int ChannelId { get; set; }
        public string Keyword { get; set; }
        public int Page { get; set; }
        public bool ShowLinked { get; set; }
        public int ShowOnPage { get; set; }
        public bool ShowUnlinked { get; set; }
        public string Source { get; set; }
        public string SubSource { get; set; }
    }
}
