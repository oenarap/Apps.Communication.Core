using System;

namespace Apps.Communication.Core
{
    public interface IQueryResult<TData, TParam> : IQueryResult<TData>
    {
        TParam Parameter { get; }
    }

    public interface IQueryResult<T> : IQueryResult
    { 
        T Data { get; }
    }

    public interface IQueryResult : IMessage { }
}
