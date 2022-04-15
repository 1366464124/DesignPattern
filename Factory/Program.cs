using System;

namespace DesignPattern.Factory
{
    class MainClass
    {
        static void Main(string[] strings)
        {
            Factory factory = new BinarySplitterFactory();
            UseFactory useFactory = new UseFactory(factory);
            useFactory.Use();
        }
    }
}