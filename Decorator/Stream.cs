using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Decorator
{
    public abstract class Stream
    {
        public abstract int Read();
        public abstract void Seek();
        public abstract void Write();
    }
}
