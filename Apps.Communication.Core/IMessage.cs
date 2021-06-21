using System;

namespace Apps.Communication.Core
{
    public interface IMessage
    {
        Guid Id { get; }
    }
}
