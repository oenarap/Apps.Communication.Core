using System.Threading.Tasks;

namespace Apps.Communication.Core
{
    public interface ICommandHub
    {
        void RegisterHandler<TCommand, THandler, TResult>(THandler handler) where THandler : IHandle<TCommand, TResult> where TCommand : ICommand;
        void RegisterValidator<TCommand, TValidator>(TValidator validator) where TValidator : IHandle<TCommand, bool> where TCommand : ICommand;
        Task<TResult> Dispatch<TCommand, TResult>(TCommand command) where TCommand : ICommand;
    }
}
