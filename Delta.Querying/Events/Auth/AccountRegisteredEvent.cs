using System;
using Delta.Core.Events;

namespace Delta.Querying.Events.Auth
{
    public class AccountRegisteredEvent : Event
    {
        public AccountRegisteredEvent(string username, string email, string shaPassHash)
        {
            Username = username;
            Email = email;
            ShaPassHash = shaPassHash;
        }

        public string Username { get; private set; }
        
        public string ShaPassHash { get; private set; }

        public string Email { get; private set; }
    }
}