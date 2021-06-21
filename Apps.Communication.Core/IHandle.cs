using System.Threading.Tasks;

namespace Apps.Communication.Core
{
    public interface IHandle<TMessage, TResult> where TMessage : IMessage
    {
        Task<TResult> Handle(TMessage message);
    }

    public interface IHandle<T> where T : IMessage
    {
        Task Handle(T message);
    }
}
