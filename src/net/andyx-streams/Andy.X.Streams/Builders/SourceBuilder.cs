using Andy.X.Streams.Abstractions;
using Andy.X.Streams.Configurations;
using System;

namespace Andy.X.Streams.Builders
{
    public class SourceBuilder<T> where T : ISourceObject
    {
        public SourceConfiguration<T> SourceConfiguration { get; private set; }

        public SourceBuilder(SourceConfiguration<T> sourceConfiguration)
        {
            SourceConfiguration = sourceConfiguration;
        }

        public SourceBuilder(Action<SourceConfiguration<T>> config)
        {
            SourceConfiguration = new SourceConfiguration<T>();
            config.Invoke(SourceConfiguration);
        }
    }
}
