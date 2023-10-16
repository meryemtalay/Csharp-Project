using System;

namespace ATMUygulamasi
{
    public class GunsonuLog
    {
        
        // Bu metod başarılı giriş loglamasını kaydeder.
        public void sLog(string ad, string soyad, int TCNo)
        {
            string girisMesaji = $"{TCNo} kimlik numaralı {ad} {soyad} kişisi {DateTime.Now} - tarihinde başarılı giriş yaptı.";
            logFile(TCNo,girisMesaji);
        }
        // Bu metod başarısız giriş loglamasını kaydeder.
        public void fLog(string ad, string soyad, int TCNo)
        {
            string girisMesaji = $"{TCNo} kimlik numaralı {ad} {soyad} kişisi {DateTime.Now} - tarihinde başarısız giriş denemesi yaptı.";
            logFile(TCNo, girisMesaji);
        }
        // Bu metod başarılı para çekme loglamasını kaydeder.
        public void sparaCekme(string ad, string soyad, int TCNo, int miktar)
        {
            string girisMesaji = $"{TCNo} kimlik numaralı {ad} {soyad} kişisi {DateTime.Now} tarihinde {miktar} miktarda başarılı para çekme işlemı gerçekleştirmiştir";
            logFile(TCNo, girisMesaji);
        }

        // Bu metod başarısız para çekme loglamasını kaydeder.
        public void fparaCekme(string ad, string soyad, int TCNo, int miktar)
        {
            string girisMesaji = $"{TCNo} kimlik numaralı {ad} {soyad} kişisi {DateTime.Now} tarihinde {miktar} miktarda başarısız para çekme işlemi denemesi gerçekleştirmiştir";
            logFile(TCNo, girisMesaji);
        }

        // Bu metod başarısız para yatırma loglamasını kaydeder.
        public void sparaYatir(string ad, string soyad, int TCNo, int miktar)
        {
            string girisMesaji = $"{TCNo} kimlik numaralı {ad} {soyad} kişisi {DateTime.Now} tarihinde {miktar} miktarda başarılı para yatırma işlemi denemesi gerçekleştirmiştir";
            logFile(TCNo, girisMesaji);
        }
        //Başarılı bakiye görüntüleme loglaması
        public void sbakiye(string ad, string soyad, int TCNo)
        {
            string girisMesaji = $"{TCNo} kimlik numaralı {ad} {soyad} kişisi {DateTime.Now} tarihinde bakiyesini görüntülemiştir";
            logFile(TCNo,girisMesaji);
        }

        //Çıkış yapma loglaması
        public void LogOut(string ad, string soyad, int TCNo)
        {
            string girisMesaji = $"{TCNo} kimlik numaralı {ad} {soyad} kişisi {DateTime.Now} tarihinde hesabından çıkış yapmıştır";
            logFile(TCNo, girisMesaji);
        }



        public void checkAndCreate()
        {
            //   Bu metot var olan listedeki her eleman için bir log dosyası oluşturma amacıyla yazılmıştır
            //   Amaç belirtilen dosya yoluna gidip o dosya yolunda belirtilen klasörü açmak yoksa ise
            //   o klasörü oluşturup listedeki her kullanıcı için bir file.txt açmak
             
            string filePath = "D:\\C# Projects\\ATMUygulamasi\\log";
            if (!Directory.Exists(filePath)) //Logların bulunduğu dosya yoksa oluşturur
            {
                Directory.CreateDirectory(filePath);//Dosya yoksa oluşturur

                foreach (var person in Data.kullanicilar)//Her kullanıcıya bir file.txt açılır
                {
                    //Aşağıdaki kod ise string ifadeleri birleştirerek bir dosya yolu oluşturur
                    string logFilePath = Path.Combine(filePath, person.TCNo + ".txt");

                    if (!File.Exists(logFilePath))
                        File.Create(logFilePath);
                }
            }
            else
            {
                // Logların bulunduğu dosya varsa listedeki elemanların her birine ait log.txt varmı diye kontrol eder yoksa açar
                foreach (var person in Data.kullanicilar)
                {
                    //Her kullanıcının TC numarası ile bir log.txt açar
                    string logFilePath = Path.Combine(filePath, person.TCNo + ".txt");
                    if (!File.Exists(logFilePath))
                        File.Create(logFilePath);
                }
            }

        }

        //Log mesajını kullanıcının log dosyasına yazdıran metot
        public void logFile(int TCNo, string girisMesaji)
        {
            //Önce log dosyalarının bulunduğu ana dosyaya gideceğiz
            string dizin = "D:\\C# Projects\\ATMUygulamasi\\log";

            //Sonra belirtilen dosya yolunu kapsayan log.txt dosya yollarını bir diziye aktaracağız
            string[] logFiles = Directory.GetFiles(dizin, TCNo + ".txt");

            if (logFiles.Length == 0)//Eğer dizi boyutu sıfırsa demekki öyle log.txt dosyaları yok
            {
                Console.WriteLine($"Belirtilen TC numarasında ( {TCNo}  ) bir kişi bulunamadı");
                return;
            }


            string logFilePath = logFiles[0];//Belirtilen koşulu sağlayan ilk log dosyasını alıyoruz

            //StreamWriter ile dosyaya yazdırma işlemi gerçekleştiriyoruz  
            using (StreamWriter logWriter=File.AppendText(logFilePath))
            {
                //AppenText() metodu var olan metin  dosyasına yeni bir metin dosyası eklemek için kullanılıır
                logWriter.WriteLine(girisMesaji);
            }
        }

        
    }
}