using System;
using System.Collections.Generic;


namespace ATMUygulamasi // Note: actual namespace depends on the project name.
{
    public class Kullanici
    {
        public Kullanici(int TCNo, string ad, string soyad,int password,int bakiye,string username)
        {
            this.TCNo=TCNo;
            this.ad=ad;
            this.soyad=soyad;
            this.password = password;
            this.bakiye= bakiye;
            this.username= username;
        }        
        public int TCNo { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public int password { get; set; }
        public int bakiye { get; set; }
        public string username{ get; set; }
    }
    public static class Data
    {
        public static List<Kullanici> kullanicilar= new List<Kullanici>();

        static Data()
        {
            kullanicilar.Add(new Kullanici(12345,"Selim","Çankaya",4739,450000,"selimcnk"));
            kullanicilar.Add(new Kullanici(12345,"Merve","Günay",4512,14000,"mrvgunay"));
            kullanicilar.Add(new Kullanici(12345,"Aslı","Durmuş",9351,500,"aslidurmus"));        
            kullanicilar.Add(new Kullanici(12345,"Elif","Kaya",8769,60000,"elfkaya"));
            kullanicilar.Add(new Kullanici(12345,"Enes","Talay",9215,186415,"enestly"));
        }
    }
}
