using System;
using System.Collections.Generic;
using Delta.Trinity.DataAccess.Commands.Auth;
using Delta.Trinity.DataAccess.ViewModels;

namespace Delta.Service.Trinity.Services.Interfaces
{
    public interface IAccountService : IDisposable
    {
        void Register(AccountViewModel customerViewModel);
        IEnumerable<AccountViewModel> GetAll();
        AccountViewModel GetById(int id);
        void Update(AccountViewModel customerViewModel);
        void Remove(Guid id);
    }
}