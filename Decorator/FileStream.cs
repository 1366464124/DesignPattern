using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Decorator
{
    public class FileStream : Stream
    {
        public override int Read()
        {
            Console.WriteLine(nameof(FileStream));
            return 0;
        }

        public override void Seek()
        {
            Console.WriteLine(nameof(FileStream));
        }

        public override void Write()
        {
            Console.WriteLine(nameof(FileStream));
        }
    }
}
