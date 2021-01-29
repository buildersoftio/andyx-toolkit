using Buildersoft.Andy.X.Client;
using Buildersoft.Andy.X.Client.Abstraction;
using Buildersoft.Andy.X.Client.Factories;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buildersoft.Andy.X.Streams.Builders
{
    public abstract class SourceBuilder<T>
    {
        protected readonly ILogger _logger;
        protected readonly AndyXClient _andyXClient;

        public SourceBuilder(AndyXClient andyXClient)
        {
            _andyXClient = andyXClient;
            _logger = _andyXClient.GetOptions().Logger.GetLoggerFactory().CreateLogger(typeof(Source<T>));
        }

        public SourceBuilder(IAndyXFactory andyXFactory)
        {
            _andyXClient = andyXFactory.CreateClient();
            _logger = _andyXClient.GetOptions().Logger.GetLoggerFactory().CreateLogger(typeof(Source<T>));
        }
    }
}
