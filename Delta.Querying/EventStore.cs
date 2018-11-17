using Delta.Core.Events;
using Delta.Core.Events.Interfaces;
using Delta.DataAccess.Repositories.EventSourcing;
using Delta.Model.Interfaces;
using Newtonsoft.Json;

namespace Delta.Querying
{
    public class EventStore : IEventStore
    {
        private readonly IEventStoreRepository _eventStoreRepository;
        private readonly IUser _user;

        public EventStore(IEventStoreRepository eventStoreRepository, IUser user)
        {
            _eventStoreRepository = eventStoreRepository;
            _user = user;
        }

        public void Save<T>(T theEvent) where T : Event
        {
            var serializedData = JsonConvert.SerializeObject(theEvent);

            var storedEvent = new StoredEvent(
                theEvent,
                serializedData,
                _user.Email);

            _eventStoreRepository.Store(storedEvent);
        }
    }
}