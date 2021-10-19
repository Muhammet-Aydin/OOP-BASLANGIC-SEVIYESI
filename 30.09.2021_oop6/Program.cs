using System;

namespace _30._09._2021_oop6
{
    class Program
    {
        static void Main(string[] args)
        {
            Takim takim1 = new Takim("leon", "mavi", "seat");//constructor mtotun aldıgı parametreler

            //burada proplara gicedek degeri biz tanımladıgımızda dolayı constuctor metot calısmayacaktır.yanı o degerler ezılecektır.bizim girdigimiz degerler proplara gidecektır.
            takim1.Model = "golf";
            takim1.Renk = "kırmızı";
            takim1.Marka = "wolsvogen";

            Takim takim2 = new Takim("i20", "Beyaz", "Hyundai", "otomatik");//constructor mtotun aldıgı parametreler

            //kendimiz fıeldlara deger atamadıgımız için constructor metot calısır.onun degerleri gider.

            Console.WriteLine(takim1.Model+" "+takim1.Renk+" "+takim1.Marka);

            Console.WriteLine(takim2.Model + " " + takim2.Renk + " " + takim2.Marka+" "+takim2.Vites);
        }
    }

    public class Takim
    {
        //bunlar consttructor metotlarım program ayaga kalktıgında bir kere çalısırlar daha calısmazlar classs ısmıyle aynı ısımde tanımlanırlar parantez içine  alacakları parametreler yazılır.altıkları parametrelerinde proplara gonderir.
        public Takim(string _model,string _renk,string _marka)
        {
            this.model = _model;
            this.renk = _renk;
            this.marka = _marka;
        } 
        public Takim(string _model, string _renk, string _marka,string _vites)
        {
            this.model = _model;
            this.renk = _renk;
            this.marka = _marka;
            this.vites = _vites;
        }
        //fieldlerim private oldugu için propertyler uzerınden dısarıya acılırlar. 

        private string model;//fıeld
        private string renk;//fıeld
        private string marka;//fıeld
        private string vites;//fıeld

        //dısarıdan get ıslemı veya içeriye set ıslemı yapılcaksa bunlar property ler uzerınden olur fıeldlarımı kımse göremez cunku private yapıdalar.prop olarakta yazmassak kımse yıne göremez yazılıncada  propun ısmı cıkar proplara yazılan ısımler fıelın buyuk harfle baslayan halıyle ısımlendırılırler.

        public string Model {
            get { return this.model; }
            set { this.model = value; }
        }
        public string Vites
        {
            get { return this.vites; }
            set { this.vites = value; }
        }
        public string Renk
        {
            get { return this.renk; }
            set { this.renk = value; }
        }
        public string Marka
        {
            get { return this.marka; }
            set { this.marka = value; }
        }
    }
}
