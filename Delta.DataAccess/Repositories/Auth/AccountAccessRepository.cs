using System.Collections.Generic;
using System.Linq;
using Delta.DataAccess.Repositories.Auth.Interfaces;
using Delta.Trinity.Auth;
using Microsoft.EntityFrameworkCore;

namespace Delta.DataAccess.Repositories.Auth
{
    public class AccountAccessRepository : Repository<AccountAccess>, IAccountAccessRepository
    {
        public AccountAccessRepository(DbContext context) : base(context)
        {
        }

        public AccountAccess GetById(int id)
        {
            return _dbSet.SingleOrDefault(aa => aa.Id.Equals(id));
        }

        public IEnumerable<AccountAccess> GetAllByGmLevel(int gmLevel)
        {
            return _dbSet.Where(aa => aa.Gmlevel.Equals((byte)gmLevel));
        }
    }
}