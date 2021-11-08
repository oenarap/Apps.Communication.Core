namespace Apps.Communication.Core
{
    public interface IEventHub
    {
        void RegisterHandler<TEvent, THandler>(THandler handler) where TEvent : IEvent where THandler : IHandle<TEvent>;
        void Dispatch<TEvent>(TEvent @event) where TEvent : IEvent;
    }
}