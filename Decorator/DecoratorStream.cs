using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Decorator
{
    public abstract class DecoratorStream: Stream
    {
        protected Stream _stream;
        protected DecoratorStream(Stream stream)
        {
            _stream = stream;
        }

        public abstract override int Read();

        public abstract override void Seek();

        public abstract override void Write();
    }
}
