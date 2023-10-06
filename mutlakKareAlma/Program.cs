using System;
// Ekrandan girilen n tane sayının 67'den küçük yada büyük olduğuna bakan. Küçük olanların farklarının toplamını, büyük ise de farkların mutlak karelerini alarak toplayıp ekrana yazdıran console uygulamasını yazınız.

// Örnek: Input: 56 45 68 77

// Output: 33 101
namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sayıları giriniz");
            string[] sayilar= Console.ReadLine().Split(' ');
            int kucuk=0;
            int buyuk=0;
        
            for(int i=0;i<sayilar.Length;i++){
                int sayiDegeri = Convert.ToInt32(sayilar[i]); // Parse işlemi düzeltilerek Convert.ToInt32 kullanılmalı.

                if (sayiDegeri < 67)
                {
                    kucuk += (67 - sayiDegeri);
                }
                else
                {
                    buyuk += (sayiDegeri - 67) * (sayiDegeri - 67);
                }
            }
                 Console.WriteLine("67'den küçük sayıların 67'den farklarının toplamı: "+ kucuk);
                 Console.WriteLine("67'den büyük sayıların farkların mutlak karelerinin toplamı : " + buyuk); 
        }
    }
}