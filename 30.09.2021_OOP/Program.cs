using System;

namespace _30._09._2021_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //MAİN METOTUDUR PROGRAM CLASSI İÇİNE BULUNUR.
            //CLASSIN FIELD MEMBERINI GORDU NESNE İÇİNDE DEGER TUTMAYI SAGLAYAN YAPILARIN KENDISIDIR.
            //CLASS ICINDEKI DEGİŞKENLERDİR.
            //NESNE İÇERİSİNDE OZELLİK/PROPERTY LER VARDIR.FIELDLARI FİLTİRELEMEYİ SAGLAR.
            // OZUNDE BİR METOTDUTR. ALGORITMIT ISLERIMLERİ YAPABİLİRSİNİZZ.
            //LAKIN BUNLARIN METOTLARDAN BİR FARKI VARDIR PARANTEZ YOKTUR PARAMTER ALMAZLAR.
            //COMPILE EDERKEN GET VE SET İSİMLERİ KULLANILIR.
            //BUNU YAPMAMIZIN SEBEBİ NESNELERİMİZDEKİ FIELDLARA DIREKT EERİŞLMESİNİ İSTEMEYİZ.
            //DOLAYISIYLA FIELDLARDAKI VERİLERİ KONTROLLU BİR SEKILDE DISARIYA ACIYORUZ VEYA DISARDAN VERŞ ALIYORUZ.
            //BOYLE DURUMLARDA  C# PROGRAMLAMA DİLİNDE PROP KULLLANILIR.
            //YANI BU ISLEM SONUCUNDA  ENCALSULATION YAPILMIŞ OLUR.
            Hesap hsp = new Hesap();
            hsp.Ad = "muhammet";
            hsp.Soyad = "aydın";
            hsp.Bakiye = 50; //buradan propa set işlemi yaptık.

            Console.WriteLine(hsp.Ad + " " + hsp.Soyad + "'ın hesap bakiyesi " + hsp.Bakiye + " tldir."); //get işlemiş yapyık.

            //PROP FIELDAKI DEGERİ MUDAHALE OLSUN OLMASIN DIREK ERİŞİM YAPILMASINI SAGLAR.FAKAT GET VE SET METOTLARINI ÜZERİNDE ACARSANIZ  YINE ERİŞİMN KONTROLÜNÜ SAGLAMIS OLURSUNUZ.
            //property encapsulatıon denilen yapıda temsil ettiği fıelddakı dataya hiç mudahale etmesede acıkca mudaha le ettırebilir.
            //prop propery ler compıle edilirken arka planda kendi fieldlarından olusturulurlar.dolasyısıya ile ekstra ayrı bir fıelda gerek yoktur.



            Araba arb = new Araba();
            Console.WriteLine(arb.Yas);



            MyClass myc = new MyClass();
            //myc.Adi = "";//sadece okunabilir deger atılamaz

            MyClass2 myc2 = new MyClass2();
            // myc.Adi = ""; //sadece okunabilir deger atılamaz
            Console.WriteLine( myc2.Soyad);
            MyClass3 my4 = new MyClass3();

         // my4.MyProperty = "ahmet";//init durumunda deger verilmesi gerkeir. boyle verilmez sadece get işlem yapılır.
        }
    }

    class Araba
    {
        //auto property initializers(c# 7.0)
        public string Marka { get; set; } = "Renoult";
        public string Renk { get; set; } = "Mavi";
        public int Yas { get; set; } = 4;
    }
    class MyClass
    {
        //ref returns
        string EgitimDurumu = "BilgeAdam";
        public ref readonly string Adi => ref Adi;  //my classın içinde adı fıeldındakı deger sadece okunabilir. get işlemi yapılır.

        //ref readonly returns ,bir sınıf ıcerısınde fıeld referansıyla dondurmeyı saglayan ve br yandan da degişkenni degeirini readonly yapan yapıdır.
    }
    class MyClass2
    {
        //expressıon -bodıed  property
        //tanımladınızı prop ' experssıon kullanmamızı saglyan söz dizimi
        public string Ad
        {
            get
            {
                return "Bilge Adam";//alttakıyle bu aynı işlemdir get işlemi yaparlar.
            }
        }

        public string Soyad => "Bilge Adam";
    }

    class MyClass3
    {
        //init only propertyies init c# ust surumler

        //nesnenin ilk yaratılıs kısmı propreytlara deger aramaktadır.
        //boylece iş  kuralı geregince runtmeda degeri degişmemesi gereken nesneler için onlem alınmıs olunur.
        //geliştiriciler acısından surec esnasında degiştirlmemesi gereken prop degerlerine "yanıslıkla " degiştirlmesinin onune deçilmiş olur.boylece bugdan kurtulmus olursunuz.
        public string MyProperty { get; init; } = "mehmet"; //bu durumda init durumunda sadece get yapılır set yapılacaksa tanımlama durumunda deger verilmemisi initilizers durumunda deger yapılması gerekir.

    }










}
////prop ornegi :
//public int MyProperty2 { get; set; }

////erisim bildirgeci deri donus tipi adı
//private int myVar;//fıeldımızın ismi 

//public int MyProperty//işlem bunun ustunde yapılır
//{
//    get
//    {
//        //bunu silersek sadece set işlemi yapılır.
//        //burası mypropetyde veri istendiğinde calıssan kısım
//        return myVar;
//    }
//   set
//    {
//        //bnu silersek sadece get  işlemş yapılır.
//        //veri gonderildiginde calısan kısım.
//        myVar = value; //gelen veri value keyworduyle yakalanır. 
//    }
//}






