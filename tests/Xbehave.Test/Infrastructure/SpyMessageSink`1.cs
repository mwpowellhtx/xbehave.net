namespace Xbehave.Test.Infrastructure
{
    using System;
    using System.Collections.Generic;
    using System.Threading;
    using Xunit.Abstractions;
    using Xunit.Sdk;

    public sealed class SpyMessageSink<TFinalMessage> : LongLivedMarshalByRefObject, IMessageSink, IDisposable
    {
        public ManualResetEvent Finished { get; } = new ManualResetEvent(initialState: false);

        public IList<IMessageSinkMessage> Messages { get; } = new List<IMessageSinkMessage>();

        public void Dispose() => this.Finished.Dispose();

        public bool OnMessage(IMessageSinkMessage message)
        {
            this.Messages.Add(message);

            if (message is TFinalMessage)
            {
                this.Finished.Set();
            }

            return true;
        }
    }
}
