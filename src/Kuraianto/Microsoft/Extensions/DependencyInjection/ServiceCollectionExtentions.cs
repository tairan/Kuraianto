using System;
using System.Collections.Generic;
using System.Text;
using Kuraianto;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtentions
    {
        public static IServiceCollection AddGrpcClient(this IServiceCollection services)
        {
            services.AddSingleton<IChannelBuilder, ChannelBuilder>();

            return services;
        }
    }
}
