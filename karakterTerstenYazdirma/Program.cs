using System;
// Verilen string ifade içerisindeki karakterleri bir önceki karakter ile yer değiştiren console uygulamasını yazınız.
// Örnek: Input: Merhaba Hello Question

// Output: erhabaM elloH uestionQ

namespace karakterTerstenYazdirma 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir cümle girin: ");
            string input = Console.ReadLine();

            string result = MoveFirstLetterToEnd(input);

            Console.WriteLine("Sonuç: " + result);

            Console.ReadLine();
        }

        static string MoveFirstLetterToEnd(string s)
        {
            //cümleyi boşluklarla kelimelere böldüm.
            string[] words = s.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                //kelimelerin ilk harfini alır. Substring(0,1) metodu stringin 0. indeksinden başlayarak 1 karakter al.
                string firstLetter = words[i].Substring(0, 1);
                // Kelimenin baş harfi hariç kısmı alınır. 
                string restOfWord = words[i].Substring(1);
                // Ve cümle birleştirilir.
                words[i] = restOfWord + firstLetter;
            }
            // words dizisindeki elemanlar boşlukla birleştirilerek maine sonuç oalrak gönderilir.
            return string.Join(" ", words);
        }
    }
}