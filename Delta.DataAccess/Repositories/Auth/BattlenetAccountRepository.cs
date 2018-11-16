using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Delta.DataAccess.Repositories.Auth.Interfaces;
using Delta.Trinity.Auth;
using Microsoft.EntityFrameworkCore;

namespace Delta.DataAccess.Repositories.Auth
{
    public class BattlenetAccountRepository : Repository<BattlenetAccount>, IBattlenetAccountRepository
    {
        public BattlenetAccountRepository(DbContext context) : base(context)
        {
        }

        public BattlenetAccount GetById(int id)
        {
            return _dbSet.SingleOrDefault(ba => ba.Id.Equals(id));
        }

        public BattlenetAccount GetByEmail(string email)
        {
            return _dbSet.SingleOrDefault(ba => ba.Email.Equals(email.ToUpper(CultureInfo.InvariantCulture)));
        }

        public IEnumerable<BattlenetAccount> GetAll()
        {
            return _dbSet;
        }

        public ICollection<BattlenetAccount> GetByLastKnownIp(string ipAddress)
        {
            return _dbSet.Where(ba => ba.LastIp.Equals(ipAddress)).ToList();
        }
    }
}