using System;

namespace DesignPattern.Factory
{
    public class BinarySplitter : ISplitter
    {
        public void Split()
        {
            Console.WriteLine(nameof(Split));
        }
    }
}
