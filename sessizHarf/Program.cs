using System;
// Verilen string ifade içerisinde yanyana 2 tane sessiz varsa ekrana true, yoksa false yazdıran console uygulamasını yazınız.

// Örnek: Input: Merhaba Umut Arya

// Output: True False True
namespace sessizHarf // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("String bir ifade giriniz.");
            string cumle = Console.ReadLine();
            string[] kelimeler = cumle.Split(' ');
            char[] sesliharfler = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };

            foreach (string kelime in kelimeler)
            {
                bool found = false;

                for (int i = 0; i < kelime.Length - 1; i++)
                {
                    char currentChar = Char.ToLower(kelime[i]);
                    char nextChar = Char.ToLower(kelime[i + 1]);
                    // Array.IndexOf(sesliharfler, currentChar) şu anki karakter (currentChar) değişkeninin sesliharfler dizisinde bulunduğu indeksi döndürür.
                    // Eğer bu karakter dizi içinde bulunmuyorsa, -1 değerini döndürür.
                    if (Array.IndexOf(sesliharfler, currentChar) == -1 && Array.IndexOf(sesliharfler, nextChar) == -1)
                    {
                        found = true;
                        break;
                    }
                }

                Console.Write(found+" ");
            } 
        }
    }
}