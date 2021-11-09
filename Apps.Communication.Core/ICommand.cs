using System;

namespace Apps.Communication.Core
{
    public interface ICommand<TData, TParam> : ICommand<TData>
    {
        TParam Parameter { get; }
    }

    public interface ICommand<T> : ICommand
    {
        T Data { get; }
    }

    public interface ICommand : IMessage { }
}
