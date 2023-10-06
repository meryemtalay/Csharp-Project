using System;
// Verilen string ifade içerisindeki ilk ve son karakterin yerini değiştirip tekrar ekrana yazdıran console uygulamasını yazınız.

// Örnek: Input: Merhaba Hello Algoritma x

// Output: aerhabM oellH algoritmA x

namespace karakterDegistirme 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir string ifade yazınız.");
            string cumle = Console.ReadLine();

            string[] kelimeler = cumle.Split(' ');
            string[] yenikelimeler = new string[kelimeler.Length];

            for (int i = 0; i < kelimeler.Length; i++)
            {
                if (kelimeler[i].Length <= 1)
                {
                    yenikelimeler[i] = kelimeler[i];
                }
                else
                {
                    char ilk = kelimeler[i][0];
                    char son = kelimeler[i][kelimeler[i].Length - 1];
                    string guncel = son + kelimeler[i].Substring(1, kelimeler[i].Length - 2) + ilk;
                    yenikelimeler[i] = guncel;
                }

                Console.WriteLine(yenikelimeler[i]);
            }

            string sonuc = string.Join(" ", yenikelimeler);
            Console.WriteLine($"Metin: {sonuc}");            
        }
    }
}
