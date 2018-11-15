using System;
using System.Threading;
using System.Threading.Tasks;
using Delta.Core.Bus;
using Delta.Core.Notifications;
using Delta.DataAccess;
using Delta.DataAccess.Interfaces;
using Delta.DataAccess.Repositories.Auth;
using Delta.DataAccess.Repositories.Auth.Interfaces;
using Delta.Trinity.Auth;
using MediatR;

namespace Delta.Querying.Commands.Auth.Handlers
{
    public class AccountCommandHandler : CommandHandler,
        IRequestHandler<CreateNewAccountCommand>
    {
        private readonly AccountRepository _accountRepository;
        private readonly IMediatorHandler Bus;

        public AccountCommandHandler(AccountRepository accountRepository, 
                                      IUnitOfWork uow,
                                      IMediatorHandler bus,
                                      INotificationHandler<DomainNotification> notifications) :base(uow, bus, notifications)
        {
            _accountRepository = accountRepository;
            Bus = bus;
        }

        public Task Handle(CreateNewAccountCommand message, CancellationToken cancellationToken)
        {
            if (!message.IsValid())
            {
                NotifyValidationErrors(message);
                return Task.CompletedTask;
            }

            var account = new Account(message.Username, message.ShaPassHash, message.Email);

            if (_accountRepository.GetByEmail(account.Email) != null)
            {
                Bus.RaiseEvent(new DomainNotification(message.MessageType, "The customer e-mail has already been taken."));
                return Task.CompletedTask;
            }
            
            _accountRepository.Add(account);

            if (Commit())
            {
                Bus.RaiseEvent(new CustomerRegisteredEvent(account.Id, account.Name, account.Email, account.BirthDate));
            }

            return Task.CompletedTask;
        }

        public void Dispose()
        {
            _accountRepository.Dispose();
        }
    }
}