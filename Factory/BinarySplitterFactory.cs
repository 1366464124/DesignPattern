using System;

namespace DesignPattern.Factory
{
    public class BinarySplitterFactory : Factory
    {
        public override ISplitter CreateSplitter()
        {
            return new BinarySplitter();
        }
    }
}
