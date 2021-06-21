using System;

namespace Apps.Communication.Core
{
    public interface ICommand<T> : ICommand
    {
        T Data { get; }
        Guid DataId { get; }
    }

    public interface ICommand : IMessage { }
}
