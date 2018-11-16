using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Delta.DataAccess.Contexts.Trinity;
using Delta.DataAccess.Repositories.Auth.Interfaces;
using Delta.Trinity.Auth;

namespace Delta.DataAccess.Repositories.Auth
{
    public class AccountRepository : Repository<Account>, IAccountRepository
    {
        public AccountRepository(AuthDataContext context) : base(context)
        {
        }

        public IEnumerable<Account> GetAll()
        {
            return _dbSet;
        }

        public Account GetByEmail(string email)
        {
            return _dbSet.FirstOrDefault(account => account.Email.Equals(email.ToUpper(CultureInfo.InvariantCulture)));
        }

        public Account GetById(int id)
        {
            return _dbSet.SingleOrDefault(account => account.Id.Equals(id));
        }

        public Account GetByUsername(string username)
        {
            return _dbSet.SingleOrDefault(account => account.Username.Equals(username.
                ToUpper(CultureInfo.InvariantCulture)));
        }

        public ICollection<Account> GetByLastKnownIp(string ipAddress)
        {
            return _dbSet.Where(accounts => accounts.LastAttemptIp.Equals(ipAddress)).ToList();
        }
    }
}