using System;
using System.Linq;
using Delta.DataAccess.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Delta.DataAccess
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly DbContext _db;
        protected readonly DbSet<TEntity> _dbSet;

        public Repository(DbContext context)
        {
            _db = context;
            _dbSet = _db.Set<TEntity>();
        }

        public virtual void Add(TEntity obj)
        {
            _dbSet.Add(obj);
        }

        public virtual TEntity GetById(Guid id)
        {
            return _dbSet.Find(id);
        }

        public virtual IQueryable<TEntity> GetAll()
        {
            return _dbSet;
        }

        public virtual void Update(TEntity obj)
        {
            _dbSet.Update(obj);
        }

        public virtual void Remove(Guid id)
        {
            _dbSet.Remove(_dbSet.Find(id));
        }

        public int SaveChanges()
        {
            return _db.SaveChanges();
        }

        public void Dispose()
        {
            _db.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}