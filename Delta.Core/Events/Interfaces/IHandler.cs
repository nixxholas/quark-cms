namespace Delta.Core.Events.Interfaces
{
    public interface IHandler<in T> where T : Message
    {
        void Handle(T message);
    }
}