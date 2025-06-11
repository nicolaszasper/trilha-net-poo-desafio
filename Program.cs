using System;
using DesafioPOO.Models;

namespace DesafioPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testando Nokia:");
            Smartphone nokia = new Nokia("11999999999", "Nokia 3310", "123456789012345", 64);
            nokia.Ligar();
            nokia.ReceberLigacao();
            nokia.InstalarAplicativo("Whasapp");

            Console.WriteLine();

            Console.WriteLine("Testando iPhone:");
            Smartphone iphone = new Iphone("11988888888", "iPhone 14", "543210987654321", 256);
            iphone.Ligar();
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("Instagram");
        }
    }
}