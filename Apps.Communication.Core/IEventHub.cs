namespace Apps.Communication.Core
{
    public interface IEventHub
    {
        void RegisterHandler<THandler, TEvent>(THandler handler) where TEvent : IEvent where THandler : IHandle<TEvent>;
        void RegisterHandler<THandler, TEvent>() where TEvent : IEvent where THandler : IHandle<TEvent>;
        void Dispatch<TEvent>(TEvent @event) where TEvent : IEvent;
    }
}