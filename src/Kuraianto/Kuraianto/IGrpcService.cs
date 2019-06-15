using System;
using System.Collections.Generic;
using System.Text;
using Grpc.Core;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;

namespace Kuraianto
{
    public interface IGrpcService
    {
        ILogger Logger { get; set; }

        Channel Channel { get; }
    }
}
