using System;

namespace ATMUygulamasi // Note: actual namespace depends on the project name.
{
    public class GirisEkrani
    {
        bool status = true;
        static Kullanici kullanicigirisi;
        public void Run()
        {        

            while(status)
            {
                Console.WriteLine("Atm Uygulamasına Hoş geldiniz.");
                Console.WriteLine("Kullanıcı adınızı giriniz:");
                string kullaniciAdi = Console.ReadLine();

                Console.WriteLine("Şifre:");
                string sifre = Console.ReadLine();            
                kullanicigirisi = Data.kullanicilar.Find(k => k.username == kullaniciAdi && k.password == int.Parse(sifre));

                if (kullanicigirisi != null)
                {            
                    Console.WriteLine("Hoşgeldin "+kullanicigirisi.ad+" "+ kullanicigirisi.soyad +"! \nLütfen yapacağın işlemi seç");
                    Console.WriteLine("1-Para Çekme\n" + "2-Para Yatırma\n" + "3-Bakiye görüntüle\n" + "4-Çıkış" + "");
                    int secim=int.Parse(Console.ReadLine());

                    switch (secim)
                    {
                        case 1:
                            paraCekme();
                            break;
                        case 2:
                            paraYatirma();
                            break;
                        case 3:
                            bakiyeGoster();
                            break;
                        case 4:
                            cikis();
                            break;
                        default:
                            Console.WriteLine("Geçersiz seçenek!");
                            break;  
                    }
                } 
                else
                {
                    Console.WriteLine("Kullanıcı adı veya şifre hatalıdır. Lütfen geçerli birkullanıcı veya şifre giriniz");
                    cikis();
                }
            }               
            }
            public void paraCekme()
            {
                Console.Write($"Güncel bakiyeniz: {kullanicigirisi.bakiye} \nLütfen çekmek istediğiniz para miktarını giriniz..");
                int miktar=int.Parse(Console.ReadLine());
                if (kullanicigirisi.bakiye>miktar)
                {
                    kullanicigirisi.bakiye-=miktar;
                    Console.WriteLine("İşlem başarıyla gerçekleştirildi.\nGüncel tutar: "+ kullanicigirisi.bakiye);
                }
                else
                {
                    Console.WriteLine("Bakiyeniz yetersiz olduğundan işlem reddedildi.");
                }
                Console.WriteLine("1-Para Çekme\n" + "2-Para Yatırma\n" + "3-Bakiye görüntüle\n" + "4-Çıkış" + "");
                int secim1=int.Parse(Console.ReadLine());

                switch (secim1)
                {
                    case 1:
                        paraCekme();
                        break;
                    case 2:
                        paraYatirma();
                        break;
                    case 3:
                        bakiyeGoster();
                        break;
                    case 4:
                        cikis();
                        break;
                    default:
                        Console.WriteLine("Geçersiz seçenek!");
                        break;  
                }                
            }

            public void paraYatirma()
            {
                Console.Write($"Güncel bakiyeniz: {kullanicigirisi.bakiye} \nLütfen yatırmak istediğiniz para miktarını giriniz..");
                int yatir=int.Parse(Console.ReadLine());

                kullanicigirisi.bakiye+= yatir;
                Console.WriteLine("İşlem başarıyla gerçekleştirildi. Güncel tutar: "+ kullanicigirisi.bakiye);
                Console.WriteLine("1-Para Çekme\n" + "2-Para Yatırma\n" + "3-Bakiye görüntüle\n" + "4-Çıkış" + "");
                int secim2=int.Parse(Console.ReadLine());

                switch (secim2)
                {
                    case 1:
                        paraCekme();
                        break;
                    case 2:
                        paraYatirma();
                        break;
                    case 3:
                        bakiyeGoster();
                        break;
                    case 4:
                        cikis();
                        break;
                    default:
                        Console.WriteLine("Geçersiz seçenek!");
                        break;  
                }                
            }

            public void bakiyeGoster()
            {
                // Bakiye görüntüleme işlemleri burada gerçekleştirilir.
                Console.WriteLine("Güncel bakiyeniz: "+ kullanicigirisi.bakiye);
                Console.WriteLine("Başka bir işlem yapmak ister misiniz?");

                Console.WriteLine("1-Para Çekme\n" + "2-Para Yatırma\n" + "3-Bakiye görüntüle\n" + "4-Çıkış" + "");
                int secim3=int.Parse(Console.ReadLine());

                switch (secim3)
                {
                    case 1:
                        paraCekme();
                        break;
                    case 2:
                        paraYatirma();
                        break;
                    case 3:
                        bakiyeGoster();
                        break;
                    case 4:
                        cikis();
                        break;
                    default:
                        Console.WriteLine("Geçersiz seçenek!");
                        break;  
                }
            }

            public void cikis()
            {
                status = false; // Kullanıcının oturumunu sonlandır
                kullanicigirisi = null; // Kullanıcı oturumunu sıfırla (çıkış yaptığında oturumu kapat)
                Console.WriteLine("Çıkış işlemi başarıyla gerçekleştirildi. İyi günler dileriz.");
            }
    }
}
