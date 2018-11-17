using System;
using System.Collections.Generic;
using Delta.Core.Events;

namespace Delta.DataAccess.Repositories.EventSourcing
{
    public interface IEventStoreRepository : IDisposable
    {
        void Store(StoredEvent theEvent);
        IList<StoredEvent> All(Guid aggregateId);
    }
}