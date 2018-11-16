using System.Collections.Generic;
using Delta.DataAccess.Interfaces;
using Delta.Trinity.Auth;

namespace Delta.DataAccess.Repositories.Auth.Interfaces
{
    public interface IBattlenetAccountRepository : IRepository<BattlenetAccount>
    {
        BattlenetAccount GetById(int id);

        BattlenetAccount GetByEmail(string email);

        IEnumerable<BattlenetAccount> GetAll();

        ICollection<BattlenetAccount> GetByLastKnownIp(string ipAddress);
    }
}