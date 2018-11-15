using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Delta.Core.Bus;
using Delta.DataAccess.Repositories.Auth.Interfaces;
using Delta.Querying.Commands.Auth;
using Delta.Service.Trinity.Services.Interfaces;
using Delta.Trinity.DataAccess.ViewModels;

namespace Delta.Service.Trinity.Services
{
    public class AccountService : IAccountService
    {   
        private readonly IMapper _mapper;
        private readonly IAccountRepository _accountRepository;
        private readonly IMediatorHandler Bus;
        
        public AccountService(IMapper mapper,
            IAccountRepository accountRepository,
            IMediatorHandler bus)
        {
            _mapper = mapper;
            _accountRepository = accountRepository;
            Bus = bus;
        }
        
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public void Register(AccountViewModel accountViewModel)
        {
            var registerCommand = _mapper.Map<CreateNewAccountCommand>(accountViewModel);
            Bus.SendCommand(registerCommand);
        }

        public IEnumerable<AccountViewModel> GetAll()
        {
            return _accountRepository.GetAll().AsQueryable().ProjectTo<AccountViewModel>();
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