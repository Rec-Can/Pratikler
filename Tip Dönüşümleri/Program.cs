using System;

namespace Tip_Dönüşümleri
{
    class Program
    {
        static void Main(string[] args)
        {
            byte a = 5;
            sbyte b = 30;
            short c = 60;

            int d = a+b+c ;

            Console.WriteLine("d:"+ d); 

            // Explicit Conversion

            int x = 4;
            byte y =(byte)x;
            Console.WriteLine("y:" +y);

            int z = 100;
            byte t =(byte)z;
            Console.WriteLine("t:" +t);

            float w = 10.7f;
            byte v =(byte)w;
            Console.WriteLine("v:" +v);

            Console.WriteLine("Sayı girin.");
            int inputInt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(inputInt);
            
        }
    }
}
