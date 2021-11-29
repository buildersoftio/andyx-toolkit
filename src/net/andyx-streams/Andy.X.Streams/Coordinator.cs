using Andy.X.Streams.Abstractions;

namespace Andy.X.Streams
{
    public abstract partial class Coordinator<TSourceObject>
    {
        private readonly ISource<ISourceObject> _source;

        public Coordinator(ISource<ISourceObject> source)
        {
            _source = source;
        }
    }
}
