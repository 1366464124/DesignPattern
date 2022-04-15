using DesignPattern.Bridge;

namespace Bridge
{
    public abstract class Messager
    {
        protected MessagerImp _messagerImp;
        public Messager(MessagerImp messagerImp)
        {
            _messagerImp = messagerImp;
        }
        public abstract void Login(string username, string password);
        public abstract void SendMessage();
        public abstract void SendPicture();
    }
}
