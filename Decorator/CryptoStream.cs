using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Decorator
{
    public class CryptoStream : DecoratorStream
    {
        public CryptoStream(Stream stream) : base(stream)
        {
        }

        public override int Read()
        {
            Console.WriteLine(nameof(CryptoStream));
            return 0;
        }

        public override void Seek()
        {
            Console.WriteLine(nameof(CryptoStream));
        }

        public override void Write()
        {
            Console.WriteLine(nameof(CryptoStream));
        }
    }
}
