using System;
using System.Collections.Generic;

// Kulanıcıdan alınan derinliğe göre fibonacci serisindeki rakamların ortalamasını alıp ekrana yazdıran uygulamayı yazınız.
namespace ortalamaHesaplama // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ortalamasını hesaplamak istediğiniz fibonacci derinliğini giriniz ..");
            
            int x=Convert.ToInt32(Console.ReadLine());
             if (x < 0)
                {
                    Console.WriteLine("Lütfen pozitif bir sayı giriniz.");
                    return;
                }
            Fibonacci(x);
        }

        public static void Fibonacci(int depth){
            int x;
            float sum=0;
            List<int> fibo=new List<int>();

            for(int i=0;i<depth;i++){
             
                if(i>1){
                    x=fibo[i-1]+fibo[i-2];
                    fibo.Add(x);
                }else{
                    fibo.Add(i);
                }
            }

            for(int i=0;i<fibo.Count;i++){
            Console.WriteLine($"Fibonacci dizisinin {i+1}. elemanı: {fibo[i]}");
               
            }
            sum=fibo.Sum();
            Console.WriteLine("Fibonacci Ortalaması:"+sum/depth);
        }

    }
}