using Bridge;
using DesingPattern.Bridge;
using System;

namespace DesignPattern.Bridge
{
    class MainClass
    {
        static void Main()
        {

            MessagerImp messagerImp = new PCMessagerImp();
            Messager messager = new MessagerLite(messagerImp);

            messager.Login("a", "b");
            messager.SendMessage();

            messager.SendPicture();
        }
    }
}