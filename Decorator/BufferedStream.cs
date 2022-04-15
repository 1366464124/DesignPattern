using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Decorator
{
    public class BufferedStream : DecoratorStream
    {
        public BufferedStream(Stream stream) : base(stream)
        {
        }

        public override int Read()
        {
            //using 
            //using base._stream;
            Console.WriteLine(nameof(BufferedStream));
            return 0;
        }

        public override void Seek()
        {
            Console.WriteLine(nameof(BufferedStream));
        }

        public override void Write()
        {
            Console.WriteLine(nameof(BufferedStream));
        }
    }
}
