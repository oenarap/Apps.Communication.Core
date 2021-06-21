namespace Apps.Communication.Core
{
    public interface IQuery<TParam> : IQuery
    {
        TParam Parameter { get; }
    }

    public interface IQuery : IMessage { }
}