using System.Threading.Tasks;
using Delta.Core.Commands;
using Delta.Core.Events;

namespace Delta.Core.Bus
{
    public interface IMediatorHandler
    {
        Task SendCommand<T>(T command) where T : Command;
        Task RaiseEvent<T>(T @event) where T : Event;
    }
}