using System;
using System.Collections.Generic;
using Delta.Core.Bus;
using Delta.Service.Trinity.Services.Interfaces;
using Delta.Trinity.DataAccess.Repositories.Auth.Interfaces;
using Delta.Trinity.DataAccess.ViewModels;

namespace Delta.Service.Trinity.Services
{
    public class AccountService : IAccountService
    {   
        private readonly IAccountRepository _accountRepository;
        private readonly IMediatorHandler Bus;
        
        public AccountService(
            IAccountRepository accountRepository,
            IMediatorHandler bus)
        {
            _accountRepository = accountRepository;
            Bus = bus;
        }
        
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public void Register(AccountViewModel customerViewModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AccountViewModel> GetAll()
        {
            //return _accountRepository.GetAll().ProjectTo<AccountViewModel>();
            throw new NotImplementedException();
        }

        public AccountViewModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(AccountViewModel customerViewModel)
        {
            throw new NotImplementedException();
        }

        public void Remove(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}