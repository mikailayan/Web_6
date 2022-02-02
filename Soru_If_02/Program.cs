using System;

namespace Soru_If_02
{
    class Program
    {
        static void Main(string[] args)
        {

            // kullanıcıdan iki adet sayı isteyip bunların;
            //topalamını farkını çarpımını ve bölümünü alt alta gösteren programı yazınız;

            //Console.WriteLine("1. sayıyı giriniz:");
            //double sayi1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("2. sayıyı giriniz:");
            //double sayi2 = Convert.ToDouble(Console.ReadLine());
            //double toplam = sayi1 + sayi2;
            //double fark = sayi1 - sayi2;
            //double carpim = sayi1 * sayi1;
            //double bolum = sayi1 / sayi2;


            //Console.WriteLine($"toplam= {sayi1}+{sayi2}={toplam}");
            //Console.WriteLine($"fark= {sayi1}-{sayi2}={fark}");
            //Console.WriteLine($"carpım= {sayi1}*{sayi2}={carpim}");
            //Console.WriteLine($"bolum= {sayi1}/{sayi2}={bolum}");





            string islem = "";
            char isaret = ' ';
            double sonuc = 0;
            double secim = 0;
            Console.WriteLine("yapmak istediğiniz işlemi giriniz;");
            Console.WriteLine("1toplam--2fark--3çarpma--4bölme");
            secim = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("1. sayıyı giriniz:");
            double sayı1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2. sayıyı giriniz:");
            double sayı2 = Convert.ToDouble(Console.ReadLine());
            if (secim == 1)
            {
                islem = "toplam=";
                sonuc = sayı1 + sayı2;
                isaret = '+';

            }
            else if (secim == 2)
            {
                islem = "fark=";
                sonuc = sayı1 - sayı2;
                isaret = '-';


            }
            else if (secim == 3)
            {
                islem = "çarpım=";
                sonuc = sayı1 * sayı2;
                isaret = '*';

            }
            else if (secim == 4)
            {
                islem = "bölüm=";
                sonuc = sayı1 / sayı2;
                isaret = '/';

            }
            else
            {
                Console.WriteLine("yanlış giriş yaptınız.");
            }
            Console.WriteLine($"{islem}{sayı1}{isaret}{sayı2}={sonuc}");









            Console.ReadLine();
        }
    }
}
