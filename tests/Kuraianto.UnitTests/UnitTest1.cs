using System;
using System.Collections.Generic;
using System.Linq;
using Grpc.Core;
using Xunit;

namespace Kuraianto.UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var channel = new ChannelBuilder()
                .AddEndpoint("localhost:5001")
                .AddOptions(options =>
                {
                   options = new List<ChannelOption>
                   {
                        new ChannelOption(ChannelOptions.MaxSendMessageLength,  2*1024*1024),
                        new ChannelOption(ChannelOptions.MaxReceiveMessageLength , 5 *1024*1024)
                   };
                })
                .Build();
        }
    }
}
