using Delta.DataAccess.Contexts.Trinity;

namespace Delta.DataAccess.Repositories
{
    public class BaseAuthRepository<T> : Repository<T> where T : class
    {
        protected new readonly AuthDataContext _db;
        
        public BaseAuthRepository(AuthDataContext context) : base(context)
        {
        }
    }
}