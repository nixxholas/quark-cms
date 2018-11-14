using Delta.Core.Commands;

namespace Delta.Trinity.DataAccess.Commands.Auth
{
    public abstract class AccountCommand : Command
    {
        public int Id { get; protected set; }

        public string Username { get; protected set; }
        
        public string ShaPassHash { get; protected set; }

        public string Email { get; protected set; }
    }
}