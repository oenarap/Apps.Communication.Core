using System;

namespace Apps.Communication.Core
{
    public interface IEvent<T> : IEvent
    {
        T Data { get; }
    }

    public interface IEvent : IMessage { }
}
