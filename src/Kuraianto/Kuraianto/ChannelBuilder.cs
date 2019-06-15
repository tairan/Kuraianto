using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Grpc.Core;

namespace Kuraianto
{
    public class ChannelBuilder : IChannelBuilder
    {
        private Uri _host;
        private int _port;
        private ChannelCredentials _credentials;
        private IEnumerable<ChannelOption> _options = Enumerable.Empty<ChannelOption>();

        public ChannelBuilder()
        {
            _host = new Uri("localhost:9111");
            _port = _host.Port;
            _credentials = ChannelCredentials.Insecure;
        }

        public IChannelBuilder AddEndpoint(string uriString)
        {
            if (string.IsNullOrWhiteSpace(uriString))
            {
                throw new ArgumentNullException(nameof(uriString));
            }

            return AddEndpoint(new Uri(uriString));
        }

        public IChannelBuilder AddEndpoint(Uri uri)
        {
            _host = uri ?? throw new ArgumentNullException(nameof(uri));
            _port = uri.Port;

            return this;
        }

        public IChannelBuilder AddCrenditials(ChannelCredentials credentials)
        {
            _credentials = credentials ?? throw new ArgumentNullException(nameof(credentials));

            return this;
        }

        public IChannelBuilder AddOptions(Action<IEnumerable<ChannelOption>> action)
        {
            action?.Invoke(_options);

            return this;
        }

        public Channel Build()
        {
            if (_host == null)
            {
                throw new ArgumentNullException(nameof(_host));
            }

            if (_credentials == null)
            {
                throw new ArgumentNullException(nameof(_credentials));
            }

            return new Channel(_host.ToString(), _port, _credentials);
        }
    }
}
