using Andy.X.Streams.Configurations;
using System;

namespace Andy.X.Streams.Builders
{
    public class CoordinatorBuilder
    {
        public CoordinatorConfiguration CoordinatorConfiguration { get; private set; }

        public CoordinatorBuilder(CoordinatorConfiguration coordinatorConfiguration)
        {
            CoordinatorConfiguration = coordinatorConfiguration;
        }

        public CoordinatorBuilder(Action<CoordinatorConfiguration> config)
        {
            CoordinatorConfiguration = new CoordinatorConfiguration();
            config.Invoke(CoordinatorConfiguration);
        }
    }
}
