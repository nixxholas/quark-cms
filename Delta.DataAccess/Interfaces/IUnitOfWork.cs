using System;

namespace Delta.DataAccess.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        bool Commit();
    }
}