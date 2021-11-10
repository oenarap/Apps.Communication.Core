using System.Threading.Tasks;

namespace Apps.Communication.Core
{
    public interface IQueryHub
    {
        void RegisterContributor<TContributor, TQueryResult>() 
            where TQueryResult : IQueryResult where TContributor : IHandle<TQueryResult>;
        void RegisterValidator<TValidator, TQuery, TQueryResult>() where TQuery : IQuery
            where TQueryResult : IQueryResult where TValidator : IHandle<TQuery, TQueryResult>;
        Task<TQueryResult> Dispatch<TQuery, TQueryResult>(TQuery query) where TQuery : IQuery 
            where TQueryResult : IQueryResult;
    }
}
