using System;
using System.Collections.Generic;
using System.Text;
using Grpc.Core;

namespace Kuraianto
{
    public interface IChannelBuilder
    {
        Channel Build();

        IChannelBuilder AddEndpoint(string uri);

        IChannelBuilder AddEndpoint(Uri uri);

        IChannelBuilder AddCrenditials(ChannelCredentials credentials);

        IChannelBuilder AddOptions(Action<IEnumerable<ChannelOption>> action);
    }
}
