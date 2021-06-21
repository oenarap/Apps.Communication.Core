using System.Threading.Tasks;

namespace Apps.Communication.Core
{
    public interface IQueryHub
    {
        void RegisterHandler<THandler, TQuery, TQueryResult>() where TQuery : IQuery where TQueryResult : IQueryResult where THandler : IHandle<TQuery, TQueryResult>;
        void RegisterPostHandler<THandler, TQueryResult>() where TQueryResult : IQueryResult where THandler : IHandle<TQueryResult>;
        Task<TQueryResult> Dispatch<TQuery, TQueryResult>(TQuery query) where TQuery : IQuery where TQueryResult : IQueryResult;
    }
}
