using System;
using System.Collections.Generic;

namespace LinnworksAPI
{
    public class BaseSession
    {
        public DateTime LastActivity;
        public string Device;
        public string DeviceType;
        public string Server;
        public StatusDetails Status;
        public string BsonId;
        public Guid Id;
        public string Email;
        public Guid UserId;
        public string UserName;
        public string UserType;
        public string Token;
        public Guid EntityId;
        public string GroupName;
        public LocalityType Locality;
        public Dictionary<string, string> Properties;
        public DataCache Cache;
    }
}