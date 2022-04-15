using System;

namespace DesignPattern.Factory
{
    public class UseFactory
    {
        Factory _factory;
        public UseFactory(Factory factory)
        {
            _factory = factory;
        }

        public void Use()
        {
            ISplitter splitter = _factory.CreateSplitter();
            splitter.Split();
        }
    }
}
