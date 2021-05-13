using System;

namespace Karar_Yapıları
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;
            // if-else-elseif
            if(time>= 6 && time<12){
                Console.WriteLine("Günaydın");
            }

            else if( time <= 12)
            {
                Console.WriteLine("İyi Günler");
            }
            else{
                Console.WriteLine("İyi Geceler");
            }
            // Ternary 

            // string sonuc = time <= 18 ? "İyi Günler" : "İyi Geceler";

            string sonuc = time>= 6 && time<12 ? "Günaydın" : time <= 12 ? "İyi Günler" : "İyi Geceler";
            Console.WriteLine(sonuc);
        }
    }
}
