using System;

namespace IntegerIkililerinToplami // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
         Console.WriteLine("Integer sayıları aralarında boşluk bırakarak giriniz (örnek: 2 3 1 5 2 5 3 3):");
        string input = Console.ReadLine();
        // stringi boşluklara bölerek bir diziye atıyorum
        string[] inputs = input.Split(' ');

        for (int i = 0; i < inputs.Length; i += 2)
        {
            int num1 = int.Parse(inputs[i]);
            int num2 = int.Parse(inputs[i + 1]);
            int toplam = num1 + num2;

            if (num1 != num2)
            {
                Console.Write(toplam + " ");
            }
            else
            {
                Console.Write(toplam * toplam + " ");
            }
        }
        }
    }
}