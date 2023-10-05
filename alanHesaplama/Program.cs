using System;

namespace alanHesaplama // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("İşlem yapmak istediğiniz geometrik şekli seçiniz");
            Console.WriteLine("***********************************************");
            Console.WriteLine("1- Daire, 2- Üçgen, 3- Kare, 4- Dikdörtgen");
            int sekil=Convert.ToInt32(Console.ReadLine());

            switch(sekil)
            {

            case 1:
                Console.WriteLine("Dairenin yarıçapını girin:");
                double yaricap = Convert.ToDouble(Console.ReadLine());
                Daire daire = new Daire(yaricap);
                Console.WriteLine("Alan: " + daire.AlanHesapla());
                Console.WriteLine("Çevre: " + daire.CevreHesapla());
                break;

            case 2:
                Console.WriteLine("Üçgenin taban uzunluğunu girin:");
                double taban = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Üçgenin yüksekliğini girin:");
                double yukseklik = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Üçgenin bir kenarını girin:");
                double kenar1 = Convert.ToDouble(Console.ReadLine());  
                Console.WriteLine("Üçgenin ikinci kenarını girin:");
                double kenar2 = Convert.ToDouble(Console.ReadLine());                                
                Ucgen ucgen = new Ucgen(taban, yukseklik,kenar1,kenar2);
                Console.WriteLine("Alan: " + ucgen.AlanHesapla());
                Console.WriteLine("Çevre: " + ucgen.CevreHesapla());
                break;

            case 3:
                Console.WriteLine("Karenin kenar uzunluğunu girin:");
                double kenar = Convert.ToDouble(Console.ReadLine());
                Kare kare = new Kare(kenar);
                Console.WriteLine("Alan: " + kare.AlanHesapla());
                Console.WriteLine("Çevre: " + kare.CevreHesapla());
                break;

            case 4:
                Console.WriteLine("Dikdörtgenin uzun kenarını girin:");
                double uzunKenar = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Dikdörtgenin kısa kenarını girin:");
                double kisaKenar = Convert.ToDouble(Console.ReadLine());
                Dikdortgen dikdortgen = new Dikdortgen(uzunKenar, kisaKenar);
                Console.WriteLine("Alan: " + dikdortgen.AlanHesapla());
                Console.WriteLine("Çevre: " + dikdortgen.CevreHesapla());
                break;

            default:
                Console.WriteLine("Geçersiz seçenek!");
                break;                
            }
        }
        
      
    }
    
    class GeometrikSekil
    {
        // Alt sınıflar tarafından değiştirilebilmesi için virtual olarak tanımlandı.(Inheritance)
        public virtual double AlanHesapla()
        {
            return 0;
        }

        public virtual double CevreHesapla()
        {
            return 0;
        }
    }
    class Daire : GeometrikSekil
    {
        private double yaricap;

        public Daire(double yaricap)
        {
            this.yaricap = yaricap;
        }

        public override double AlanHesapla()
        {
            return Math.PI * yaricap * yaricap;
        }

        public override double CevreHesapla()
        {
            return 2 * Math.PI * yaricap;
        }
    }

    class Ucgen : GeometrikSekil
    {
        private double taban;
        private double yukseklik;
        private double kenar1;
        private double kenar2;

        public Ucgen(double taban, double yukseklik, double kenar1,double kenar2)
        {
            this.taban = taban;
            this.yukseklik= yukseklik;
            this.kenar1=kenar1;
            this.kenar2=kenar2;
        }

        public override double AlanHesapla()
        {
            return (taban * yukseklik)/2;
        }

        public override double CevreHesapla()
        {
            return taban+kenar1+kenar2;
        }
    }


    class Kare: GeometrikSekil
    {
        private double kenar;

        public Kare(double kenar)
        {
            this.kenar=kenar;
        }
        public override double AlanHesapla()
        {
            return kenar*kenar;
        }
        public override double CevreHesapla()
        {
            return kenar*4;
        }

    }
    class Dikdortgen:GeometrikSekil
    {
        private double kisaKenar;
        private double uzunKenar;

        public Dikdortgen(double kisaKenar, double uzunKenar)
        {
            this.kisaKenar=kisaKenar;
            this.uzunKenar=uzunKenar;
        }
        public override double AlanHesapla()
        {
            return uzunKenar*kisaKenar;
        }
         public override double CevreHesapla()
        {
            return (kisaKenar+uzunKenar)*2;
        }       
    }
}