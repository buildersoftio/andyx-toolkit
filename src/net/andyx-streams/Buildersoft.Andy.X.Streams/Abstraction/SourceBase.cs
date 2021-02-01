using Buildersoft.Andy.X.Client;
using Buildersoft.Andy.X.Client.Abstraction;
using Buildersoft.Andy.X.Client.Configurations;
using Buildersoft.Andy.X.Streams.Configurations;
using Microsoft.Extensions.Logging;
using System;

namespace Buildersoft.Andy.X.Streams.Abstraction
{
    public abstract class SourceBase<T>
    {
        protected readonly ILogger _logger;
        protected readonly AndyXClient _andyXClient;
        protected readonly Reader<T> _reader;

        protected readonly SourceOptions _sourceOptions;

        public SourceBase(AndyXClient andyXClient, Action<ReaderOptions> readerOptionsAction)
        {
            _andyXClient = andyXClient;

            var readerOpt = new ReaderOptions();
            readerOptionsAction?.Invoke(readerOpt);

            _logger = _andyXClient.GetOptions().Logger.GetLoggerFactory().CreateLogger(typeof(Source<T>));
        }

        public SourceBase(IAndyXFactory andyXFactory, Action<ReaderOptions> readerOptionsAction)
        {
            _andyXClient = andyXFactory.CreateClient();

            var readerOpt = new ReaderOptions();
            readerOptionsAction?.Invoke(readerOpt);

            _logger = _andyXClient.GetOptions().Logger.GetLoggerFactory().CreateLogger(typeof(Source<T>));
        }
    }
}
