using System;

namespace _05._10._2021_İnheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //oop en onemlı ve en cok kullanılan ozelliğidir.
            //uretılen nesneler farklı nesleere ozellıklerını atarabilmekte  boyle hiyerarsık bır yapı olusuyordu.
            //aynı aıle grubundan gelen nesnelerın yada  yatay hızada esıt olan nesnelerın nemzer ozellıklerı tekrar tkear herbırıne tnımlamak bir ust sınıftan mıras almasını saglıyoruz
            //boylece hem kod malıyetını dusmekte hemde mımasrısel acıdan avantaj saglamaktadır.
            //ONEMLI NOTLAR
            //OOP UYUMLU BÜTÜN YAZILIM DILLERINDE 
            //SADECE SINIF YAILARI KALITIM ALIRLAR.
            //C# : KALITIM OPERATORUDUR.
            //BİR SINIFIN SADECE BİR TANE BASE CLASI OLUR
            //BİR SIFININ BASE CLASII TUREDIGI SINIFIR.
            //BİR CLASSIN BİRDEN FAZLA CHİLD CLASI OLABİLR.
            //KLAITIM ALAN SINIFA DERİVED,CHİLD CLASS DENİR.
            //KALTIIM VEREN SINIFA BASE CLAS DENİR.



            Yazılımcı yzl = new Yazılımcı();
            yzl.BildiğiYazılımDili = "c#";
            yzl.Ad = "muhammet";
            yzl.Soyad = "aydın";
            yzl.CinsiyetDurum =true;
           //3u baseden geldı biri kendı ozellıgıdır.


        }



    }
    class Çalışanlar
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public bool CinsiyetDurum { get; set; }
    }

    class Muhasebe: Çalışanlar
    {

    }
    class Yazılımcı : Çalışanlar
    {
        public string BildiğiYazılımDili { get; set; }

    }
    class Müdürler : Çalışanlar
    {

        public string ManegedDepartman { get; set; }
    }
    class İnsanKaynaklari : Çalışanlar
    {

    }
   
  




}
