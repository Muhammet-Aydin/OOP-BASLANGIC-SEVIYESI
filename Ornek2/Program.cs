using System;

namespace Ornek2
{
    class Program
    {

       
        /// field nesne içerisinde deger tutmayı saglanyan yapılardır
        /// //class içerisindeki degişkenkerdir
        /// //herhangı bir turden olabılırler
        /// /eger degişken class içerisindeyse field olarak tanımlanıyorsa defoult degerlr verilebilir
        /// //yok eger classta degill metot vs ıcerınde tanımlanıyorsa defoult verilmez.
       
        static void Main(string[] args)
        {
            Araba m1 = new Araba();//araba classının araba tipinde m1 referansıya ınstancesını aldık.

            m1.VitesTipi = "düz";//m1 referansıyla araba clasnın ıcındekı fıela deger koyduk.
            m1.Yil =30;

            Araba m2 = new Araba();

            m2.VitesTipi = "otomatık";//
            m2.Yil = 25;

            Console.WriteLine(m1.Yil);
            Console.WriteLine(m1.VitesTipi);

            Console.WriteLine(m2.Yil);
            Console.WriteLine(m2.VitesTipi);
        }
        class Araba
        {
            public int Yil;//class ıcınde int tipinde bir fıeld tanımladık.
            public string VitesTipi;

        }
    }
}
