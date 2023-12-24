using DesafioPOO.Models;
using System;

namespace DesafioPOO
{
    class Program
    {
        static void Main()
        {
            // Testando a classe Nokia
            Nokia nokia = new Nokia("123456", "NokiaModelo", "IMEI123", 64);
            nokia.Ligar();
            nokia.ReceberLigacao();
            nokia.InstalarAplicativo("WhatsApp");

            // Testando a classe Iphone
            Iphone iphone = new Iphone("789012", "iPhoneModelo", "IMEI456", 128);
            iphone.Ligar();
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("Twitter");
        }
    }
}
