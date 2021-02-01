using Buildersoft.Andy.X.Client;
using Buildersoft.Andy.X.Client.Abstraction;
using Buildersoft.Andy.X.Client.Configurations;
using Buildersoft.Andy.X.Client.Events;
using Buildersoft.Andy.X.Streams.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buildersoft.Andy.X.Streams
{
    public class Source<T> : SourceBase<T>, ISource<T>
    {
        public Source(AndyXClient andyXClient, Action<ReaderOptions> readerOptions) : base(andyXClient, readerOptions)
        {

        }

        public Source(IAndyXFactory andyXFactory, Action<ReaderOptions> readerOptions) : base(andyXFactory, readerOptions)
        {

        }
    }
}
