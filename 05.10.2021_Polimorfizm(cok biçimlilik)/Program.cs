using System;

namespace _05._10._2021_Polimorfizm_cok_biçimlilik_
{
    class Program
    {
        static void Main(string[] args)
        {
            //2yada daha fazla nesnenin aynı tur sınıf tarafından referans edilebilmesi.
            //bir nesnenin birden fazla turdeki referans tarafından işsartelenmesine cok biçimlilik denir.



            //q calasından bir ornek alırken
            //Q q=new Q();
            //polimorfizmde programlamadakı temel prensibi olan sol sag prensıbı acıp elde edilen nesne birden fazla referansla işsaretlenebilir.
            //bir nesnenin irden fazla referansla işsaretlkenmesi o nesnenin birden fazla turun davranısını gösterecegi  manasına gelir.
            //object turunden herhangı br degerinin alınması yada herhangı bır veri tipine deger atayabilmemiz.polimorfizm ornegıdır.
            object o = "muhammet";
            //string o1 = o;
            string o2 = (string)o;

            string deger = "deger";
            object deger1 = deger;


            MyClass1 deger5;

            new MyClass();

            MyClass1 deger6 = new MyClass();
        }
    }
    class MyClass:MyClass1
    {

    }
    class MyClass1
    {

    }
}
