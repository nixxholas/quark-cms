using System.Collections;
using System.Collections.Generic;
using Delta.DataAccess.Interfaces;
using Delta.Trinity.Auth;

namespace Delta.DataAccess.Repositories.Auth.Interfaces
{
    public interface IAccountAccessRepository : IRepository<AccountAccess>
    {
        AccountAccess GetById(int id);

        IEnumerable<AccountAccess> GetAllByGmLevel(int gmLevel);
    }
}