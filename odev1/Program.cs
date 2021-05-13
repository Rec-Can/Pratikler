using System;

namespace odev1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region soru1
            /* Console.WriteLine("Kaç sayı girmek istiyorusunuz?");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[n];
            Console.WriteLine("Sayıları giriniz.");
            for (int i = 0; i < n; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Çift sayılar: ");
            foreach (var number in numbers)
            {
                if(number % 2 == 0)
                {
                    Console.Write(number + ", ");
                }
            } */
            #endregion

            #region soru2

            /* Console.WriteLine("Pozitif iki sayı girin.");
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[n];
            Console.WriteLine("Girdiğiniz ilk sayı kadar pozitif sayı girin.");
            for (int i = 0; i < n; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Girdiğiniz ikinci sayıya bölünen sayılar: ");
            foreach (var number in numbers)
            {
                if(number % m == 0)
                {
                    Console.Write(number + ", ");
                }
            } */

            #endregion

            #region soru3
            /*
            Console.WriteLine("Kaç kelime girmek istiyorusunuz?");
            int n = Convert.ToInt32(Console.ReadLine());
            string[] kelimeler = new string[n];

            Console.WriteLine("Kelimeleri giriniz.");
            for (int i = 0; i < n; i++)
            {
                kelimeler[i] = Console.ReadLine();
            }
            Array.Reverse(kelimeler);
            foreach (var item in kelimeler)
            {
                Console.WriteLine(item);
            }
            */
            #endregion

            #region soru4

            Console.WriteLine("Bir cümle giriniz.");
            string cumle = Console.ReadLine();
            string cumle2 = cumle.Trim();
            string[] c = cumle2.Split(" ");

            Console.WriteLine("Kelime Sayısı : " + c.Length);

            Console.WriteLine("Harf sayısı: " + cumle2.Replace(" ", "").Length);

             
                
            #endregion
        }
    }
}
