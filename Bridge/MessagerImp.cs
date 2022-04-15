using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Bridge
{
    public abstract class MessagerImp
    {
        public abstract void PlaySound();
        public abstract void DrawShape();
        public abstract void WriteText();
        public abstract void Connect();
    }
}
