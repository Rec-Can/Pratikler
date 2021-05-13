using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sort
            int[] sayıDizisi = {76,45,78,94,14,3,5,9};

            Console.WriteLine("***Sırasız Dizi***");
            foreach (var sayi in sayıDizisi)
                Console.WriteLine(sayi);
            
            Console.WriteLine("***Sıralı Dizi***");
            System.Array.Sort(sayıDizisi);
            foreach (var sayi in sayıDizisi)
                Console.WriteLine(sayi);

            // Clear
            Console.WriteLine("***Array Clear***");

            System.Array.Clear(sayıDizisi,2,2);
            foreach (var sayi in sayıDizisi)
                Console.WriteLine(sayi);

            
            // Reverse
            Console.WriteLine("***Array Reverse***");
            System.Array.Reverse(sayıDizisi);
            foreach (var sayi in sayıDizisi)
                Console.WriteLine(sayi);

            // IndexOf
            Console.WriteLine("***Array IndexOf***");
            Console.WriteLine(System.Array.IndexOf(sayıDizisi,45));

            // Resize
            Console.WriteLine("***Array Resize***");
            System.Array.Resize<int>(ref sayıDizisi,9);
            sayıDizisi[8] = 99;

            foreach (var sayi in sayıDizisi)
                Console.WriteLine(sayi);
        }
    }
}
