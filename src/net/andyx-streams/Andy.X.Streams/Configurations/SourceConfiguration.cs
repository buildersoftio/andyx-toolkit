using Andy.X.Client.Configurations;
using Andy.X.Streams.Abstractions;

namespace Andy.X.Streams.Configurations
{
    public class SourceConfiguration<T> where T : ISourceObject
    {
        public string Name { get; set; }
        public string Component { get; set; }
        public string Topic { get; set; }

        public SubscriptionType SubscriptionType { get; set; }
        public InitialPosition InitialPosition { get; set; }

        public SourceConfiguration()
        {
            Name = "default_source";
            Component = "default";
            Topic = "default";
            SubscriptionType = SubscriptionType.Exclusive;
            InitialPosition = InitialPosition.Latest;
        }
    }
}
