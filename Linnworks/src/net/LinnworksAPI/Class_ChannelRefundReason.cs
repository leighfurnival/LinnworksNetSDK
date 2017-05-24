using System.Collections.Generic;

namespace LinnworksAPI
{
    public class ChannelRefundReason
    {
        public string Tag;
        public string DisplayName;
        public List<ChannelRefundSubReason> SubReasons;
    }
}