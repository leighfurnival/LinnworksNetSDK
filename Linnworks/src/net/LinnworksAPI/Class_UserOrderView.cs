using System;

namespace LinnworksAPI
{
    public class UserOrderView
    {
        public DateTime ModifiedDateTime;
        public int pkViewId;
        public string ViewName;
        public string OwnerName;
        public bool? AllowModify;
        public string JSONDetail;
    }
}