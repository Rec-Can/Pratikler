using System;

namespace Switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = DateTime.Now.Month;

            switch (month)
            {
                case 1:
                Console.WriteLine("Aylardan Ocak");
                break;
                case 2:
                Console.WriteLine("Aylardan Şubat");
                break;
                case 5:
                Console.WriteLine("Aylardan Mayıs");
                break;
                
                case 6:
                case 7:
                case 8:
                Console.WriteLine("Yaz");
                break;

                
                default:
                break;
            }
        }
    }
}
