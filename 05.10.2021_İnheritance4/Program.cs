using System;

namespace _05._10._2021_İnheritance4
{
    class Program
    {
        static void Main(string[] args)
        {
            //BASE VE THİS KEYWRODLARI ARASINDAKI FARKLAR

            Deger dgr = new Deger();
            //dgr. yazdıgımızda gelenler object sınıfından tureyen ozellileridr.
        }
    }
    class A
    {
        int a;
        public int b;
        public int MyProperty { get; set; }
    }
    class B:A
    {
        int c;
        public void fonk()
        {
            //this. dediğimizde b ve c gelir biri kendı sınıfının fıeldı dir digeri kaltıım aldıgı sınıfın public oldugu için  gelir int a gelmez cunku privatetir.
            this.b=5;
            this.c=15;
            //base. üst clasın fıeldlarına erısım saglarız ordanda  b gelir VE MY PROPERTY GELİR. a yıne gelmez cunku privatetır.
            base.b = 90;
            base.MyProperty = 10;

          
        }

    }

    class Deger
    {

    }
}
