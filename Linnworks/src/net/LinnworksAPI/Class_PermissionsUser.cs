using System;

namespace LinnworksAPI
{
    public class PermissionsUser
    {
        public int UserId;
        public bool SuperAdmin;
        public Guid fkUserId;
        public bool IsRequestingUser;
        public string EmailAddress;
        public string UserType;
    }
}