using System;

namespace enum_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Günler.Pazar);
        }
        enum Günler
    {
        Pazartesi,
        Salı,
        Çarşamba,
        Perşembe,
        Cuma,
        Cumartesi,
        Pazar
    }
    }
}
