using System;
using Business.Concrete;
using Entities.Concrete;

namespace WorkAround
{
    class Program
    {
        static void Main(string[] args)
        {
            Degiskenler();

            SelamVer(isim: "Mustafa");
            SelamVer(isim: "Yasin");
            SelamVer(isim: "Saliha");
            SelamVer();

            int sonuc = Topla(6,58);

            //diziler /arrays
            string ogrenci1 = "Mustafa";
            string ogrenci2 = "Ahu";
            string ogrenci3 = "Eymen";

            //Console.WriteLine(ogrenci1);
            //Console.WriteLine(ogrenci2);
            //Console.WriteLine(ogrenci3);

            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Mustafa";
            ogrenciler[1] = "Ahu";
            ogrenciler[2] = "Eymen";

            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }


            string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
            string[] sehirler2 = new[] { "Ankara", "İstanbul", "İzmir" };

            sehirler2 = sehirler1;
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]);

            
            foreach (string sehir in sehirler1) 
            {
                Console.WriteLine(sehir);
            }
            Person person1 = new Person();
            person1.FirstName = "Mustafa";
            person1.LastName = "GEDİZ";
            person1.DateOfBirthYear = 1987;
            person1.NationalIdentity = 49009135696;




            Person person2 = new Person();
            person2.FirstName = "Eymen";

            List<string> yenisehirler1 = new List<string> { "Konya", "Sivas", "Tokat" };
            yenisehirler1.Add(item: "Kayseri");

            foreach (var yenisehirler in yenisehirler1)
            {
                Console.WriteLine(yenisehirler);
            }

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);

            Console.ReadLine();
        }

        static void SelamVer(string isim = "isimsiz")
        {
            Console.WriteLine("Merhaba " + isim);
        }

        static int Topla(int sayi1 = 5, int sayi2 = 10)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam : " + sonuc);
            return sonuc;
        }

        private static void Degiskenler()
        {
            string mesaj = "Merhaba";

            double tutar = 100000; //db den gelir(database).

            int sayi = 100; //burada ondalık veremiyoruz.tam sayı olacak

            bool GirisYapmismi = false;

            string Ad = "Mustafa";
            string Soyad = "Gediz";
            int DogumYili = 1987;
            long TcNo = 49009135696;

            Console.WriteLine(mesaj);

            Console.WriteLine(mesaj);
        }
    }
}
