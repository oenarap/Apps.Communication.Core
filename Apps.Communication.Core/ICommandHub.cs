using System.Threading.Tasks;

namespace Apps.Communication.Core
{
    public interface ICommandHub
    {
        void RegisterHandler<THandler, TCommand, TResult>() where TCommand : ICommand where THandler : IHandle<TCommand, TResult>;
        void RegisterPreHandler<THandler, TCommand>() where TCommand : ICommand where THandler : IHandle<TCommand, bool>;
        Task<TResult> Dispatch<TCommand, TResult>(TCommand command) where TCommand : ICommand;
    }
}
