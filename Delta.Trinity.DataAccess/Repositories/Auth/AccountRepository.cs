using System.Collections.Generic;
using System.Linq;
using Delta.DataAccess;
using Delta.DataAccess.Contexts.Trinity;
using Delta.Trinity.Auth;
using Delta.Trinity.DataAccess.Repositories.Auth.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Delta.Trinity.DataAccess.Repositories.Auth
{
    public class AccountRepository : Repository<Account>, IAccountRepository
    {
        public AccountRepository(AuthDataContext context) : base(context)
        {
        }

        public Account GetById(int id)
        {
            return _dbSet.SingleOrDefault(account => account.Id.Equals(id));
        }

        public Account GetByUsername(string username)
        {
            return _dbSet.SingleOrDefault(account => account.Username.Equals(username));
        }

        public ICollection<Account> GetByLastKnownIp(string ipAddress)
        {
            return _dbSet.Where(accounts => accounts.LastAttemptIp.Equals(ipAddress)).ToList();
        }
    }
}