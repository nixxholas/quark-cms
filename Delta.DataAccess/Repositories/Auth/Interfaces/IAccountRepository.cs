using System.Collections.Generic;
using Delta.Trinity.Auth;

namespace Delta.DataAccess.Repositories.Auth.Interfaces
{
    public interface IAccountRepository
    {
        Account GetById(int id);

        Account GetByUsername(string username);

        Account GetByEmail(string email);

        IEnumerable<Account> GetAll();

        ICollection<Account> GetByLastKnownIp(string ipAddress);
    }
}