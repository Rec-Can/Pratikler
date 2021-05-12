using System;

namespace Operatörler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            int x = 3;
            int y = 4;
            int z = x + y;

            bool isSuccess = true;
            bool isCompleted = false;

            Console.WriteLine(y);
            y += 2;
            Console.WriteLine(x+y);
            z *= 2;
            Console.WriteLine(z);

            if (isSuccess)
            {
                Console.WriteLine(z/x);
            }
            if (isSuccess && !isCompleted)
            {
                Console.WriteLine(z%y);
            }
        }
    }
}
