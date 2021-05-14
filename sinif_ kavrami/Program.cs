using System;

namespace sınıf_kavramı
{
    class Program
    {
        static void Main(string[] args)
        {
            Calısan calısan1 = new Calısan();
            calısan1.Ad = "Recep Can";
            calısan1.Soyad =" Keçeci";
            calısan1.No =12345678 ;
            calısan1.Departman ="Game-Dev";

            Calısan calısan2 = new Calısan();
            calısan2.Ad = "Çağatay";
            calısan2.Soyad =" Önder";
            calısan2.No =12345679 ;
            calısan2.Departman ="Backend";

            calısan1.CalısanBilgileri();
            calısan2.CalısanBilgileri();
        }
    }

    class Calısan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;
        public void CalısanBilgileri()
        {
            Console.WriteLine("Çalışan Adı:{0}",Ad);
            Console.WriteLine("Çalışan Soyadı:{0}",Soyad);
            Console.WriteLine("Çalışan Numarası:{0}",No);
            Console.WriteLine("Çalışan Departmanı:{0}",Departman);
        }


    }
}