

using System.Threading;
using System.Threading.Tasks;
using Delta.Core.Bus;
using Delta.Core.Notifications;
using Delta.DataAccess;
using Delta.DataAccess.Interfaces;
using Delta.DataAccess.Repositories.Auth.Interfaces;
using Delta.Querying.Events.Auth;
using Delta.Trinity.Auth;
using MediatR;

namespace Delta.Querying.Commands.Auth.Handlers
{
    public class AccountCommandHandler : CommandHandler,
        IRequestHandler<CreateNewAccountCommand>
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IAccountAccessRepository _accountAccessRepository;
        private readonly IBattlenetAccountRepository _battlenetAccountRepository;
        private readonly IMediatorHandler Bus;

        public AccountCommandHandler(IAccountRepository accountRepository, 
                                      IUnitOfWork uow,
                                      IMediatorHandler bus,
                                      INotificationHandler<DomainNotification> notifications) :base(uow, bus, notifications)
        {
            _accountRepository = accountRepository;
            Bus = bus;
        }

        public Task<Unit> Handle(CreateNewAccountCommand message, CancellationToken cancellationToken)
        {
            if (!message.IsValid())
            {
                NotifyValidationErrors(message);
                return Unit.Task;
            }

            var account = new Account(message.Username, message.ShaPassHash, message.Email);
            var bnetAccount = new BattlenetAccount(account.Email, account.ShaPassHash);
            // TODO: Multi-realm support
            var accountAccess = new AccountAccess(0, 1);
            
            if (_accountRepository.GetByEmail(account.Email) != null)
            {
                Bus.RaiseEvent(new DomainNotification(message.MessageType, "The customer e-mail has already been taken."));
                return Unit.Task;
            }
            
            _accountRepository.Add(account);
            _battlenetAccountRepository.Add(bnetAccount);
            _accountAccessRepository.Add(accountAccess);

            if (Commit())
            {
                Bus.RaiseEvent(new AccountRegisteredEvent(account.Username, account.Email, account.ShaPassHash));
            }

            return Unit.Task;
        }

        public void Dispose()
        {
            _accountRepository.Dispose();
        }
    }
}