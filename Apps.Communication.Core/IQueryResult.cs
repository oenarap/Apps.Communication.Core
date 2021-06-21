using System;

namespace Apps.Communication.Core
{
    public interface IQueryResult<T> : IQueryResult, IDisposable
    { 
        T Data { get; }
    }

    public interface IQueryResult : IMessage { }
}
