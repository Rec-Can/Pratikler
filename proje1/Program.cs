using System;
using System.Collections.Generic;

namespace proje1
{
    
    class Program
    {
        // rehberin tutulacağı listeyi tanımla
        static List<contact> rehber = new List<contact>();
        static void Main(string[] args)
        {
            // 1-5 arasında bir tamsayı girdisi yazılana kadar menü dönüyor
            int key = 0;
            while (key < 1 || key > 5)
            {
                Console.Clear(); // her işlem öncesi görsel karmaşayı önlemek için konsol temizleniyor
                Console.WriteLine("Lütfen yapmak istediğiniz işlemin kodunu girin.");
                Console.WriteLine("************************************************");
                Console.WriteLine("(1) Yeni Numara Kaydetme");
                Console.WriteLine("(2) Varolan Numarayı Silme");
                Console.WriteLine("(3) Varolan Numarayı Güncelleme");
                Console.WriteLine("(4) Rehberi Listeleme");
                Console.WriteLine("(5) Rehberde Arama Yapma");
                key = Convert.ToInt32(Console.ReadLine());

                switch (key)
                {
                    case 1:
                        YeniNumaraKaydetme();
                        break;
                    case 2:
                        NumaraSilme();
                        break;
                    case 3:
                        NumaraGuncelleme();
                        break;
                    case 4:
                        RehberiListele();
                        break;
                    case 5:
                        RehberdeAramaYapma();
                        break;

                    default:
                        key = 0;
                        continue;
                }     
            }             
        }
        static void YeniNumaraKaydetme()
        {
            Console.Clear();
            contact temp = new contact(); // yeni kişi için yeni geçici bir contact değişkeni tanımlandı

            Console.Write("Lütfen isim giriniz: ");
            temp.isim = Console.ReadLine();
            Console.Write("Lütfen soyisim giriniz: ");
            temp.soyisim = Console.ReadLine();
            Console.Write("Lütfen telefon numarası giriniz: ");
            temp.numara = Console.ReadLine();
            
            rehber.Add(temp);  // yeni kişi rehber listesine eklendi
            Console.WriteLine("Kişi başarıyla kaydedildi.");
            Console.ReadKey(); // herhangi bir girdi ile kod devam ediyor
            Main(null);        // işlemlere devam etmek için main fonksiyonu tekrar çağrılıyor
        }

        static void NumaraSilme()
        {
            Console.Clear();
            Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz: ");
            var temp = Console.ReadLine();
            bool bulundu = false;
            for (int i = rehber.Count - 1; i > 0; i--)
            {               
                if(rehber[i].isim == temp || rehber[i].soyisim == temp)
                {
                    bulundu = true;
                    Console.WriteLine(temp + " isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)");
                    string confirm = Console.ReadLine();
                    if(confirm == "y")
                    {
                        rehber.RemoveAt(i); // eşleşme bulduğumuz i'inci eleman listeden siliniyor
                        Console.WriteLine("Kişi kaydı başarıyla silindi.");
                        Console.ReadKey();
                        Main(null);
                    }
                    else{ NumaraSilme(); }
                }
            }
            if(!bulundu) // eğer eşleşme bulunamazsa bir önceki if içindeki kodlar çalışmadığı 
            {            // için bulundu bool değişkeni false olarak devam edip buradaki kodu çalıştırıyor
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("Silmeyi sonlandırmak için : (1)");
                Console.WriteLine("Yeniden denemek için :      (2)");
                int selection = Convert.ToInt32(Console.ReadLine());
                if (selection == 1)
                { 
                    Main(null);
                }
                else
                { 
                    NumaraSilme(); 
                }
            }            
        }

        static void RehberdeAramaYapma()
        {
            Console.Clear();
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
            Console.WriteLine("***************************************");
            Console.WriteLine("İsim veya soyisime göre arama yapmak için : (1)");
            Console.WriteLine("Telefon numarasına göre arama yapmak için : (2)");
            int selection = Convert.ToInt32(Console.ReadLine());
            if (selection == 1)
            {
                Console.WriteLine("İsim ya da soyisim giriniz");
                string isim_soyisim = Console.ReadLine();
                for (int i = 0; i < rehber.Count; i++)
                {
                    if (rehber[i].isim == isim_soyisim || rehber[i].soyisim == isim_soyisim)
                    {
                        Console.WriteLine("İsim: " + rehber[i].isim);
                        Console.WriteLine("Soyisim: " + rehber[i].soyisim);
                        Console.WriteLine("Telefon numarası: " + rehber[i].numara);                       
                    }
                }
                Console.ReadKey();
                Main(null);

            }
            if (selection == 2)
            {
                Console.WriteLine("Telefon numarası giriniz.");
                string tel_no = Console.ReadLine();
                for (int i = 0; i < rehber.Count; i++)
                {
                    if (rehber[i].numara == tel_no)
                    {
                        Console.WriteLine("İsim: " + rehber[i].isim);
                        Console.WriteLine("Soyisim: " + rehber[i].soyisim);
                        Console.WriteLine("Telefon numarası: " + rehber[i].numara);
                    }
                }
                Console.ReadKey();
                Main(null);
            }
            else
            {
                RehberdeAramaYapma();
            }
            
        }

        static void RehberiListele()
        {
            Console.Clear();
            Console.WriteLine("A-Z listele: (1)");
            Console.WriteLine("Z-A listele: (2)");
            int selection = Convert.ToInt32(Console.ReadLine());
            // rehber listesi isme göre alfabetik olarak sıralanıyor
            rehber.Sort((x, y) => x.isim.CompareTo(y.isim));
            
            if (selection == 2)
            { 
                rehber.Reverse(); // 2 seçilirse liste tersine çevriliyor
            }
            Console.WriteLine("Telefon Rehberi.\n");
            
            foreach (contact temp in rehber)
            {
                Console.WriteLine("İsim: " + temp.isim);
                Console.WriteLine("Soyisim: " + temp.soyisim);
                Console.WriteLine("Telefon Numarası: " + temp.numara);
                Console.WriteLine("-");
            }
            Console.ReadKey();
            Main(null);
        }

        static void NumaraGuncelleme()
        {
            Console.Clear();
            Console.WriteLine("Lütfen telefon numarasını değiştirmek istediğiniz kişinin adını ya da soyadını giriniz: ");
            var temp = Console.ReadLine();
            bool bulundu = false;
            for (int i = 0; i < rehber.Count; i++)
            {               
                if(rehber[i].isim == temp || rehber[i].soyisim == temp)
                {
                    bulundu = true;
                    Console.WriteLine("Lütfen yeni telefon numarası giriniz.");
                    string new_number = Console.ReadLine();
                    rehber[i].numara = new_number;
                    Console.WriteLine("Telefon numarası başarıyla değiştirildi.");
                    Console.ReadKey();
                    Main(null);
                }
            }
            if(!bulundu)
            {
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("Güncellemeyi sonlandırmak için : (1)");
                Console.WriteLine("Yeniden denemek için :           (2)");
                int selection = Convert.ToInt32(Console.ReadLine());
                if (selection == 1)
                { 
                    Main(null);
                }
                else
                { 
                    NumaraGuncelleme(); 
                }
            }         
        }
    }
    public class contact
    {
        public string isim, soyisim, numara;
    }
}
