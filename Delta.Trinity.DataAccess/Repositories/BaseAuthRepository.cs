using Delta.DataAccess;
using Delta.DataAccess.Contexts.Trinity;
using Microsoft.EntityFrameworkCore;

namespace Delta.Trinity.DataAccess.Repositories
{
    public class BaseAuthRepository<T> : Repository<T> where T : class
    {
        protected new readonly AuthDataContext _db;
        
        public BaseAuthRepository(AuthDataContext context) : base(context)
        {
        }
    }
}