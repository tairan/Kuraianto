using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtentions
    {
        public static IServiceCollection AddGrpcClient(this IServiceCollection services)
        {
            services.AddHttpClient();
            return services;
        }
    }
}
