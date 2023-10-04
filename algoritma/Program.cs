using System;
// Ekrandan bir string bir de sayı alan (aralarında virgül ile), ilgili string ifade içerisinden verilen indexteki karakteri çıkartıp ekrana yazdıran console uygulasını yazınız.
// Örnek: Input: Algoritma,3 Algoritma,5 Algoritma,22 Algoritma,0

// Output: Algritma Algortma Algoritma lgoritma
namespace algoritma 
{
    internal class Program
    {
    static void Main()
        {
            Console.Write("Bir cümle girin: ");
            string input = Console.ReadLine();

            string result = RemoveCommasAndNumbers(input);

            Console.WriteLine("Sonuç: " + result);

            Console.ReadLine();
        }

        static string RemoveCommasAndNumbers(string s)
        {
            // Önce virgülleri kaldıralım
            string removedCommas = s.Replace(",", "");

            // Sonra sayıları kaldıralım
            string removedNumbers = new string(removedCommas.Where(c => !Char.IsDigit(c)).ToArray());

            return removedNumbers;
        }


    }
}