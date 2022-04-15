using Bridge;
using DesignPattern.Bridge;
using System;

namespace DesingPattern.Bridge
{
    public class MessagerLite : Messager
    {
        public MessagerLite(MessagerImp messagerImp) : base(messagerImp)
        {
        }

        public override void Login(string username, string password)
        {
            _messagerImp.Connect();
        }

        public override void SendMessage()
        {
            _messagerImp.WriteText();
        }

        public override void SendPicture()
        {
            _messagerImp.PlaySound();
            _messagerImp.DrawShape();
        }
    }
}
