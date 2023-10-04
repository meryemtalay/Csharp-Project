using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Dairenin yarıçapını giriniz.");
            float yaricap = float.Parse(Console.ReadLine());


            for (int y = -(int)yaricap; y <= (int)yaricap; y++)
            {
                for (int x = -(int)yaricap; x <= (int)yaricap; x++)
                {
                    if (x * x + y * y <= yaricap * yaricap)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write("-");
                    }
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}