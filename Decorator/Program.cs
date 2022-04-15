using DesignPattern.Decorator;
using System;

namespace DesignPattern
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Decorator.Stream stream = new Decorator.FileStream();
            CryptoStream cryptoStream = new CryptoStream(stream);
            Decorator.BufferedStream bufferedStream = new Decorator.BufferedStream(stream);

            Decorator.Stream bufferedCryptoStream = new Decorator.BufferedStream(cryptoStream);

            stream.Read();

            cryptoStream.Write();

            bufferedStream.Seek();

            bufferedCryptoStream.Read();
        }
    }
}