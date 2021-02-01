using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buildersoft.Andy.X.Streams.Configurations
{
    public class SourceOptions
    {
        public SourceTypes SourceType { get; set; }
        public int Replicas { get; set; }
        public int Throttle { get; set; }
        public SourceOptions()
        {
            SourceType = SourceTypes.Normal;
            Replicas = 1;
            Throttle = 1;
        }
    }

    public enum SourceTypes
    {
        Normal,
        WithBackpressure
    }
}
