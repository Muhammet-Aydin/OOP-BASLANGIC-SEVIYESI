using System;

namespace _04._10._2021_ENCAPSULTION
{
    class Program
    {
        static void Main(string[] args)
        {
            //BİR FIELDIN UZERNDE VERİ KONTROLU YPAILCAKSA GET SET METOTLARI YAPILIR.
            MyClass my = new MyClass();
            my.zSet(15);
            Console.WriteLine(my.zGet()); 
        }
        class MyClass
        {
            int z;//z işelminin prop olmadan encapsıtıon ıslemı yapılaması.

            public int zGet()
            {
                //deger çekilmeden onceki işlemleri burada yapılır.
                return this.z;
            }
            public void zSet(int value)
            {
                //degerle ilgili işlem yapılacaksa buradan yapılır.
                //o sekılde gonderılır.
                this.z = value;
            }
            //encapsultıon nersnelerdeki fıeld kontrolü:kontrollu bşr srkılde dısarı acılması dısardan gelicekleri kontrollü sekılde almayı saglar.










        }
    }
}
