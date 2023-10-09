using System;

namespace ATMUygulamasi // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // GirisEkrani nesnesi oluşturuluyor
            GirisEkrani girisEkrani = new GirisEkrani();

            // GirisEkrani sınıfının Run metodunu çağırıyoruz
            girisEkrani.Run();
        }
    }
}