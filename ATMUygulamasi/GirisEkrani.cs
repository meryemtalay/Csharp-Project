using System;

namespace ATMUygulamasi
{
    public class GirisEkrani
    {
        bool status = true;

        public GunsonuLog log = new GunsonuLog();
        static Kullanici kullanicigirisi;


        public void Run()
        {
            while (status)
            {
                log.checkAndCreate();

                Console.WriteLine("Atm Uygulamasına Hoş geldiniz.");
                Console.WriteLine("Kullanıcı adınızı giriniz:");
                string kullaniciAdi = Console.ReadLine();

                Console.WriteLine("Şifre:");
                string sifre = Console.ReadLine();
                kullanicigirisi = Data.kullanicilar.Find(k => k.username == kullaniciAdi && k.password == int.Parse(sifre));

                if (kullanicigirisi != null)
                {
                    log.sLog(kullanicigirisi.ad, kullanicigirisi.soyad, kullanicigirisi.TCNo);
                    Console.WriteLine("Hoşgeldin " + kullanicigirisi.ad + " " + kullanicigirisi.soyad + "! \nLütfen yapacağın işlemi seç");
                    Console.WriteLine("1-Para Çekme\n" + "2-Para Yatırma\n" + "3-Bakiye görüntüle\n" + "4-Çıkış" + "");
                    int secim = int.Parse(Console.ReadLine());

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
                    Console.WriteLine("Kullanıcı adı veya şifre hatalıdır. Lütfen geçerli bir kullanıcı veya şifre giriniz");
                    cikis();
                }
            }
        }

        public void paraCekme()
        {
            Console.Write($"Güncel bakiyeniz: {kullanicigirisi.bakiye} \nLütfen çekmek istediğiniz para miktarını giriniz..");
            int miktar = int.Parse(Console.ReadLine());
            if (kullanicigirisi.bakiye > miktar)
            {
                kullanicigirisi.bakiye -= miktar;
                Console.WriteLine("İşlem başarıyla gerçekleştirildi.\nGüncel tutar: " + kullanicigirisi.bakiye);
                log.sparaCekme(kullanicigirisi.ad, kullanicigirisi.soyad, kullanicigirisi.TCNo, miktar);
            }
            else
            {
                Console.WriteLine("Bakiyeniz yetersiz olduğundan işlem reddedildi.");
                log.fparaCekme(kullanicigirisi.ad, kullanicigirisi.soyad, kullanicigirisi.TCNo, miktar);
            }

            Console.WriteLine("1-Para Çekme\n" + "2-Para Yatırma\n" + "3-Bakiye görüntüle\n" + "4-Çıkış" + "");
            int secim1 = int.Parse(Console.ReadLine());

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
            int yatir = int.Parse(Console.ReadLine());

            kullanicigirisi.bakiye += yatir;
            Console.WriteLine("İşlem başarıyla gerçekleştirildi. Güncel tutar: " + kullanicigirisi.bakiye);
            log.sparaYatir(kullanicigirisi.ad, kullanicigirisi.soyad, kullanicigirisi.TCNo, yatir);

            Console.WriteLine("1-Para Çekme\n" + "2-Para Yatırma\n" + "3-Bakiye görüntüle\n" + "4-Çıkış" + "");
            int secim2 = int.Parse(Console.ReadLine());

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
            Console.WriteLine("Güncel bakiyeniz: " + kullanicigirisi.bakiye);
            log.sbakiye(kullanicigirisi.ad, kullanicigirisi.soyad, kullanicigirisi.TCNo);
            Console.WriteLine("Başka bir işlem yapmak ister misiniz?");

            Console.WriteLine("1-Para Çekme\n" + "2-Para Yatırma\n" + "3-Bakiye görüntüle\n" + "4-Çıkış" + "");
            int secim3 = int.Parse(Console.ReadLine());

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
            //log.LogOut(kullanicigirisi.username, kullanicigirisi.password);
            status = false;
            kullanicigirisi = null;
            Console.WriteLine("Çıkış işlemi başarıyla gerçekleştirildi. İyi günler dileriz.");
        }
    }
}
