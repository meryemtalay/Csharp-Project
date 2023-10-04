using System;
//Kullanıcıdan alınan boyut bilgisine göre console'a Üçgen çizen uygulamayı yazınız.
namespace ucgenCizme 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Üçgeni çizmek istediğiniz boyutu veriniz");
            int x= Convert.ToInt32(Console.ReadLine());

            for(int i=1;i<=x;i++){
                for(int j=1;j<=i;j++){
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}