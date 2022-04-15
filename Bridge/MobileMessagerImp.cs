using System;

namespace DesignPattern.Bridge
{
    public class MobileMessagerImp : MessagerImp
    {
        public override void Connect()
        {
            Console.WriteLine(nameof(Connect));
        }

        public override void DrawShape()
        {
            Console.WriteLine(nameof(DrawShape));
        }

        public override void PlaySound()
        {
            Console.WriteLine(nameof(PlaySound));
        }

        public override void WriteText()
        {
            Console.WriteLine(nameof(WriteText));
        }
    }
}
