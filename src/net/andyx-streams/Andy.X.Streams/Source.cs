using Andy.X.Client;
using Andy.X.Streams.Abstractions;
using Andy.X.Streams.Builders;
using System.Collections.Concurrent;

namespace Andy.X.Streams
{
    public abstract partial class Source<TSourceObject> : ISource<TSourceObject> where TSourceObject : ISourceObject
    {
        private readonly XClient _xClient;
        private readonly SourceBuilder<TSourceObject> _sourceBuilder;

        private readonly ConcurrentDictionary<string, Flow<IFlowRequest, IFlowResponse>> _flows;

        public Source(XClient xClient, SourceBuilder<TSourceObject> sourceBuilder)
        {
            _xClient = xClient;
            _sourceBuilder = sourceBuilder;

            _flows = new ConcurrentDictionary<string, Flow<IFlowRequest, IFlowResponse>>();
        }

        public abstract void Integration(TSourceObject sourceMessage);

        // TODO: implement consumer into source ...
    }
}
